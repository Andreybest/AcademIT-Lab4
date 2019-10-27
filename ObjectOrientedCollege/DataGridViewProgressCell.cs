using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectOrientedCollege
{
    class DataGridViewProgressCell : DataGridViewImageCell
    {
        // Используется для соответствия типу DataGridViewImageCell
        static Image emptyImage;
        // Используется для хранения цвета заливки прогресс-бара
        static Color _ProgressBarColor;

        public Color ProgressBarColor
        {
            get { return _ProgressBarColor; }
            set { _ProgressBarColor = value; }
        }

        static DataGridViewProgressCell()
        {

            emptyImage = new Bitmap(1, 1, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        }
        public DataGridViewProgressCell()
        {
            this.ValueType = typeof(int);
        }
        // Метод требуется для соответствия Progress Cell типу ячейки по умолчанию Image Cell.
        // Ячейка по умолчанию Image Cell обрабатывает изображение как значение, а в нашей ячейке это значением является целое число.
        protected override object GetFormattedValue(object value,
            int rowIndex, ref DataGridViewCellStyle cellStyle,
            TypeConverter valueTypeConverter,
            TypeConverter formattedValueTypeConverter,
            DataGridViewDataErrorContexts context)
        {
            return emptyImage;
        }

        protected override void Paint(System.Drawing.Graphics g,
            System.Drawing.Rectangle clipBounds,
            System.Drawing.Rectangle cellBounds,
            int rowIndex,
            DataGridViewElementStates cellState,
            object value, object formattedValue,
            string errorText,
            DataGridViewCellStyle cellStyle,
            DataGridViewAdvancedBorderStyle advancedBorderStyle,
            DataGridViewPaintParts paintParts)
        {
            if (Convert.ToInt16(value) == 0 || value == null)
            {
                value = 0;
            }

            int progressVal = Convert.ToInt32(value);

            float percentage = ((float)progressVal / 100.0f);
            Brush backColorBrush = new SolidBrush(cellStyle.BackColor);
            Brush foreColorBrush = new SolidBrush(cellStyle.ForeColor);

            // Рисование рамки ячейки
            base.Paint(g, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, (paintParts & ~DataGridViewPaintParts.ContentForeground));

            float posX = cellBounds.X;
            float posY = cellBounds.Y;

            float textWidth = TextRenderer.MeasureText(progressVal.ToString() + "%", cellStyle.Font).Width;
            float textHeight = TextRenderer.MeasureText(progressVal.ToString() + "%", cellStyle.Font).Height;

            // Положение текста в зависимости от выравнивания в ячейке
            switch (cellStyle.Alignment)
            {
                case DataGridViewContentAlignment.BottomCenter:
                    posX = cellBounds.X + (cellBounds.Width / 2) - textWidth / 2;
                    posY = cellBounds.Y + cellBounds.Height - textHeight;
                    break;
                case DataGridViewContentAlignment.BottomLeft:
                    posX = cellBounds.X;
                    posY = cellBounds.Y + cellBounds.Height - textHeight;
                    break;
                case DataGridViewContentAlignment.BottomRight:
                    posX = cellBounds.X + cellBounds.Width - textWidth;
                    posY = cellBounds.Y + cellBounds.Height - textHeight;
                    break;
                case DataGridViewContentAlignment.MiddleCenter:
                    posX = cellBounds.X + (cellBounds.Width / 2) - textWidth / 2;
                    posY = cellBounds.Y + (cellBounds.Height / 2) - textHeight / 2;
                    break;
                case DataGridViewContentAlignment.MiddleLeft:
                    posX = cellBounds.X;
                    posY = cellBounds.Y + (cellBounds.Height / 2) - textHeight / 2;
                    break;
                case DataGridViewContentAlignment.MiddleRight:
                    posX = cellBounds.X + cellBounds.Width - textWidth;
                    posY = cellBounds.Y + (cellBounds.Height / 2) - textHeight / 2;
                    break;
                case DataGridViewContentAlignment.TopCenter:
                    posX = cellBounds.X + (cellBounds.Width / 2) - textWidth / 2;
                    posY = cellBounds.Y;
                    break;
                case DataGridViewContentAlignment.TopLeft:
                    posX = cellBounds.X;
                    posY = cellBounds.Y;
                    break;

                case DataGridViewContentAlignment.TopRight:
                    posX = cellBounds.X + cellBounds.Width - textWidth;
                    posY = cellBounds.Y;
                    break;

            }

            if (percentage >= 0.0)
            {

                // Рисование прогресса
                g.FillRectangle(new SolidBrush(_ProgressBarColor), cellBounds.X + 2, cellBounds.Y + 2, Convert.ToInt32((percentage * cellBounds.Width * 0.8)), cellBounds.Height / 1 - 5);
                // Рисование текста
                g.DrawString(progressVal.ToString() + "%", cellStyle.Font, foreColorBrush, posX, posY);
            }
            else
            {
                // При отрицательном значении отображается только текст
                if (this.DataGridView.CurrentRow.Index == rowIndex)
                {
                    g.DrawString(progressVal.ToString() + "%", cellStyle.Font, new SolidBrush(cellStyle.SelectionForeColor), posX, posX);
                }
                else
                {
                    g.DrawString(progressVal.ToString() + "%", cellStyle.Font, foreColorBrush, posX, posY);
                }
            }
        }

        public override object Clone()
        {
            DataGridViewProgressCell dataGridViewCell = base.Clone() as DataGridViewProgressCell;
            if (dataGridViewCell != null)
            {
                dataGridViewCell.ProgressBarColor = this.ProgressBarColor;
            }
            return dataGridViewCell;
        }

        internal void SetProgressBarColor(int rowIndex, Color value)
        {
            this.ProgressBarColor = value;
        }

    }
}
