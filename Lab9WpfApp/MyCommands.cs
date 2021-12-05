using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lab7WpfApp
{
    class MyCommands
    {
        public static RoutedCommand Exit { get; set; }
        public static RoutedCommand Open { get; set; }
        public static RoutedCommand Save { get; set; }
        static MyCommands()
        {
            Exit = new RoutedCommand();
            Open = new RoutedCommand();
            InputGestureCollection input = new InputGestureCollection();
            input.Add(new KeyGesture(Key.T, ModifierKeys.Control, "Ctrl+T"));
            Save = new RoutedCommand("Сохранить", typeof(MyCommands), input);
        }
    }
}
