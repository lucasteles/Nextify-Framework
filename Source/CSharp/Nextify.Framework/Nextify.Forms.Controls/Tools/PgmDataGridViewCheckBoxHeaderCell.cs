using System.Drawing;
using System.Windows.Forms;

namespace Nextify.Forms.Controls.Tools
{
    public class PgmDataGridViewCheckBoxHeaderCell : DataGridViewColumnHeaderCell
    {
        private Point _checkBoxLocation;
        private Size _checkBoxSize;
        private bool _checked;
        private Point _cellLocation;
        private System.Windows.Forms.VisualStyles.CheckBoxState _cbState = System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal;
        protected override void Paint(Graphics graphics,
                                      Rectangle clipBounds,
                                      Rectangle cellBounds,
                                      int rowIndex,
                                      DataGridViewElementStates dataGridViewElementState,
                                      object value,
                                      object formattedValue,
                                      string errorText,
                                      DataGridViewCellStyle cellStyle,
                                      DataGridViewAdvancedBorderStyle advancedBorderStyle,
                                      DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex,
                dataGridViewElementState, value,
                formattedValue, errorText, cellStyle,
                advancedBorderStyle, paintParts);
            var p = new Point();
            var s = CheckBoxRenderer.GetGlyphSize(graphics,
            System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal);
            p.X = cellBounds.Location.X +
                (cellBounds.Width / 2) - (s.Width / 2);
            p.Y = cellBounds.Location.Y +
                (cellBounds.Height / 2) - (s.Height / 2);
            _cellLocation = cellBounds.Location;
            _checkBoxLocation = p;
            _checkBoxSize = s;
            if (_checked)
                _cbState = System.Windows.Forms.VisualStyles.
                    CheckBoxState.CheckedNormal;
            else
                _cbState = System.Windows.Forms.VisualStyles.
                    CheckBoxState.UncheckedNormal;
            CheckBoxRenderer.DrawCheckBox
            (graphics, _checkBoxLocation, _cbState);
        }

        protected override void OnMouseClick(DataGridViewCellMouseEventArgs e)
        {
            var p = new Point(e.X + _cellLocation.X, e.Y + _cellLocation.Y);
            if (p.X >= _checkBoxLocation.X && p.X <=
                _checkBoxLocation.X + _checkBoxSize.Width
            && p.Y >= _checkBoxLocation.Y && p.Y <=
                _checkBoxLocation.Y + _checkBoxSize.Height)
            {
                //CheckBox
                _checked = !_checked;
                //Check All
                foreach (DataGridViewRow row in DataGridView.Rows)
                {
                    ((DataGridViewCheckBoxCell)row.Cells[e.ColumnIndex]).Value = _checked;
                }
                DataGridView.InvalidateColumn(this.ColumnIndex);
                DataGridView.RefreshEdit();
            }
            base.OnMouseClick(e);
        }
        public void SetCheckBoxValue(bool value, int index)
        {
            //DataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            _checked = value && (bool)((DataGridViewCheckBoxCell)DataGridView.Rows[index].Cells[this.ColumnIndex]).EditedFormattedValue;
            //OnCheckBoxClicked?.Invoke(_checked);
            DataGridView.InvalidateCell(this);
            //DataGridView.RefreshEdit();
        }
    }
}
