using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSource.Presentation.Helper
{
    public static class CenterForms
    {
        public static void CenterForm(Form form)
        {
            // Lấy kích thước của màn hình
            Screen screen = Screen.FromControl(form);
            int screenWidth = screen.Bounds.Width;
            int screenHeight = screen.Bounds.Height;

            // Tính toán vị trí x và y cho form để đặt nó ở giữa màn hình
            int formWidth = form.Width;
            int formHeight = form.Height;
            int x = (screenWidth - formWidth) / 2;
            int y = (screenHeight - formHeight) / 2;

            // Đặt vị trí cho form
            form.Location = new Point(x, y);
        }
    }
}
