using System.Drawing;
using System.Windows.Forms;

namespace PictureBox
{
    class ButtonsManager
    {
        private Color buttonColor, buttonMousOverColor;
        Button btPrevious, btNext;
        System.Windows.Forms.PictureBox pbMainPicture;

        public ButtonsManager(Button buttonPrev, Button buttonNext, System.Windows.Forms.PictureBox pictureBox)
        {
            this.btPrevious = buttonPrev;
            this.btNext = buttonNext;
            this.pbMainPicture = pictureBox;

            SetColorForButtons();
            InitializeButtons();
        }

        private void SetColorForButtons()
        {
            buttonColor = new Color();
            buttonMousOverColor = new Color();
            buttonColor = Color.FromArgb(0, 150, 150, 150);
            buttonMousOverColor = Color.FromArgb(120, 120, 120, 120);
        }

        private void InitializeButtons()
        {
            btPrevious.FlatAppearance.BorderSize = 0;
            btPrevious.FlatAppearance.MouseDownBackColor = buttonColor;
            btPrevious.FlatAppearance.MouseOverBackColor = buttonMousOverColor;
            btPrevious.BackColor = buttonColor;
            btPrevious.ForeColor = buttonMousOverColor;
            btPrevious.Parent = pbMainPicture;

            btNext.FlatAppearance.BorderSize = 0;
            btNext.FlatAppearance.MouseDownBackColor = buttonColor;
            btNext.FlatAppearance.MouseOverBackColor = buttonMousOverColor;
            btNext.BackColor = buttonColor;
            btNext.ForeColor = buttonMousOverColor;
            btNext.Parent = pbMainPicture;

            ButtonsStatusSet(false);
        }

        public void ButtonsStatusSet(bool status)
        {
            btNext.Visible = status;
            btPrevious.Visible = status;
        }
    }
}
