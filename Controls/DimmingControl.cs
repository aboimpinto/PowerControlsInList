using System;
using Avalonia;
using Avalonia.Controls;

namespace PowerControlsInList.Controls
{
    public class DimmingControl : UserControl
    {
        public int DimmingValue 
        {
            get => (int)GetValue(DimmingValueProperty);
            set => SetValue(DimmingValueProperty, value);
        }

        public static AvaloniaProperty DimmingValueProperty = 
            AvaloniaProperty.Register<DimmingControl, int>(nameof(DimmingValue));

        public DimmingControl()
        {
            this.DimmingValue = 50;
        }

        public void PowerUpCommand()
        {
            this.DimmingValue += 10;

            if (this.DimmingValue > 100)
            {
                this.DimmingValue = 100;
            }
        }

        public void PowerDownCommand()
        {
            this.DimmingValue -= 10;

            if (this.DimmingValue < 0)
            {
                this.DimmingValue = 0;
            }
        }
    }
}
