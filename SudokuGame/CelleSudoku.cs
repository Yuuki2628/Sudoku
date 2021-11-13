using System.Windows.Forms;

namespace Sudoku
{
    class CelleSudoku : Button
    {
        public int Valore { get; set; }
        public bool IsLocked { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Clear()
        {
            this.Text = string.Empty;
            this.IsLocked = false;
        }
    }
}
