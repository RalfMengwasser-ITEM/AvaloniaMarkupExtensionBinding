using Avalonia.Data;
using Avalonia.Markup.Xaml;
using Avalonia.Markup.Xaml.MarkupExtensions;
using System;

namespace Translations
{
    public class Translate : MarkupExtension
    {
        public string Key { get; }

        public Translate(string key)
        {
            Key = key;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            ReflectionBindingExtension binding = new ReflectionBindingExtension($"[{Key}]")
            {
                Mode = BindingMode.OneWay,
                Source = TranslateBind.Instance,
                FallbackValue = Key,
                TargetNullValue = Key
            };

            return binding.ProvideValue(serviceProvider);
        }
    }
}
