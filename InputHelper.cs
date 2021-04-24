using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace mnd.Common
{
    public class InputHelper
    {
        public static class SendKeys
        {
            public static void Send(Key key)
            {
                if (Keyboard.PrimaryDevice != null)
                {
                    if (Keyboard.PrimaryDevice.ActiveSource != null)
                    {
                        KeyEventArgs k = new KeyEventArgs(Keyboard.PrimaryDevice, Keyboard.PrimaryDevice.ActiveSource, 0, key)
                        { RoutedEvent = Keyboard.KeyDownEvent };

                        InputManager.Current.ProcessInput(k);
                    }
                }
            }
        }
    }
}
