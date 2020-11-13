using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accademy.Winform.Tris
{
    partial class Form1
    {
        #region row 0
        // Handle the KeyDown event to determine the type of character entered into the control.
        private void txt_00_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            // Initialize the flag to false.
            txt_00_IsCorrect = false;

            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                if (e.KeyCode == Keys.O || e.KeyCode == Keys.X)
                {
                    txt_00_IsCorrect = true;
                }
            }
            else if (Control.ModifierKeys == Keys.Shift)
            {
                if (e.KeyCode == Keys.O || e.KeyCode == Keys.X)
                {
                    txt_00_IsCorrect = true;
                }
            }
            else
            {
                this.lbl_error.Text = "Valori possibili sono 'X' e 'O' ";
                e.Handled = true;
            }

        }
        // This event occurs after the KeyDown event and can be used to prevent
        // characters from entering the control.
        private void txt_00_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (txt_00_IsCorrect == true)
            {
                switch (lastMove)
                {
                    case Moves.X:
                        if (e.KeyChar == 88)
                        {
                            this.lbl_error.Text = "E' il turno di B";
                            e.Handled = true;
                        }
                        else
                        {
                            lastMove = Moves.O;
                            Move(2, 0, 0);
                            this.txt_00.Enabled = false;
                            if (IsWinner("B")){this.label2.Text = "B wins"; EndGame();}
                        }
                        break;
                    case Moves.O:
                        if (e.KeyChar == 88)
                        {
                            lastMove = Moves.X;
                            Move(1, 0, 0);
                            this.txt_00.Enabled = false;
                            if (IsWinner("A")){this.label2.Text = "A wins"; EndGame();}
                        }
                        else
                        {
                            this.lbl_error.Text = "E' il turno di A";
                            e.Handled = true;
                        }
                        break;
                    case Moves.NoMoveYet:
                        if (e.KeyChar == 88)
                        {
                            lastMove = Moves.X;
                            Move(1, 0, 0);
                            this.txt_00.Enabled = false;
                        }
                        else
                        {
                            lastMove = Moves.O;
                            Move(2, 0, 0);
                            this.txt_00.Enabled = false;
                        }
                        break;
                    default:
                        break;
                }
                // Stop the character from being entered into the control since it is non-numerical.
                //e.Handled = true;
            }
            else
                e.Handled = true;
        }



        private void txt_01_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            // Initialize the flag to false.
            txt_01_IsCorrect = false;

            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                if (e.KeyCode == Keys.O || e.KeyCode == Keys.X)
                {
                    txt_01_IsCorrect = true;
                }
            }
            else if (Control.ModifierKeys == Keys.Shift)
            {
                if (e.KeyCode == Keys.O || e.KeyCode == Keys.X)
                {
                    txt_01_IsCorrect = true;
                }
            }
            else
            {
                this.lbl_error.Text = "Valori possibili sono 'X' e 'O' ";
                e.Handled = true;
            }

        }
        // This event occurs after the KeyDown event and can be used to prevent
        // characters from entering the control.
        private void txt_01_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (txt_01_IsCorrect == true)
            {
                switch (lastMove)
                {
                    case Moves.X:
                        if (e.KeyChar == 88)
                        {
                            this.lbl_error.Text = "E' il turno di B";
                            e.Handled = true;
                        }
                        else
                        {
                            Move(2, 0, 1);
                            lastMove = Moves.O;
                            this.txt_01.Enabled = false;
                            if (IsWinner("B")){this.label2.Text = "B wins"; EndGame();}
                        }
                        break;
                    case Moves.O:
                        if (e.KeyChar == 88)
                        {
                            Move(1, 0, 1);
                            lastMove = Moves.X;
                            this.txt_01.Enabled = false;
                            if (IsWinner("A")){this.label2.Text = "A wins"; EndGame();}
                        }
                        else
                        {
                            this.lbl_error.Text = "E' il turno di A";
                            e.Handled = true;
                        }
                        break;
                    case Moves.NoMoveYet:
                        if (e.KeyChar == 88)
                        {
                            Move(1, 0, 1);
                            lastMove = Moves.X;
                            this.txt_01.Enabled = false;
                        }
                        else
                        {
                            Move(2, 0, 1);
                            lastMove = Moves.O;
                            this.txt_01.Enabled = false;
                        }
                        break;
                    default:
                        break;
                }
                // Stop the character from being entered into the control since it is non-numerical.
                //e.Handled = true;
            }
            else
                e.Handled = true;
        }


        private void txt_02_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            // Initialize the flag to false.
            txt_02_IsCorrect = false;

            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                if (e.KeyCode == Keys.O || e.KeyCode == Keys.X)
                {
                    txt_02_IsCorrect = true;
                }
            }
            else if (Control.ModifierKeys == Keys.Shift)
            {
                if (e.KeyCode == Keys.O || e.KeyCode == Keys.X)
                {
                    txt_02_IsCorrect = true;
                }
            }
            else
            {
                this.lbl_error.Text = "Valori possibili sono 'X' e 'O' ";
                e.Handled = true;
            }

        }
        // This event occurs after the KeyDown event and can be used to prevent
        // characters from entering the control.
        private void txt_02_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (txt_02_IsCorrect == true)
            {
                switch (lastMove)
                {
                    case Moves.X:
                        if (e.KeyChar == 88)
                        {
                            this.lbl_error.Text = "E' il turno di B";
                            e.Handled = true;
                        }
                        else
                        {
                            Move(2, 0, 2);
                            lastMove = Moves.O;
                            this.txt_02.Enabled = false;
                            if (IsWinner("B")){this.label2.Text = "B wins"; EndGame();}
                        }
                        break;
                    case Moves.O:
                        if (e.KeyChar == 88)
                        {
                            Move(1, 0, 2);
                            lastMove = Moves.X;
                            this.txt_02.Enabled = false;
                            if (IsWinner("A")){this.label2.Text = "A wins"; EndGame();}
                        }
                        else
                        {
                            this.lbl_error.Text = "E' il turno di A";
                            e.Handled = true;
                        }
                        break;
                    case Moves.NoMoveYet:
                        if (e.KeyChar == 88)
                        {
                            Move(1, 0, 2);
                            lastMove = Moves.X;
                            this.txt_02.Enabled = false;
                        }
                        else
                        {
                            Move(2, 0, 2);
                            lastMove = Moves.O;
                            this.txt_02.Enabled = false;
                        }
                        break;
                    default:
                        break;
                }
                // Stop the character from being entered into the control since it is non-numerical.
                //e.Handled = true;
            }
            else
                e.Handled = true;
        }

        #endregion
    }
}
