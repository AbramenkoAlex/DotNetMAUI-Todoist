using UIKit;

namespace Todoist.Platforms.iOS.Helpers
{
    public static partial class KeyboardHelper
    {
        public static void HideKeyboard()
        {
            UIApplication.SharedApplication.Delegate.GetWindow().EndEditing(true);
        }
    }
}
