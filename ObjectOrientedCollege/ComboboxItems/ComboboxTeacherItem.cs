namespace ObjectOrientedCollege
{
    // https://stackoverflow.com/questions/3063320/combobox-adding-text-and-value-to-an-item-no-binding-source
    class ComboboxTeacherItem
    {
        public string Text { get; set; }
        public Teacher Value { get; set; }

        public ComboboxTeacherItem(string Text, Teacher Value)
        {
            this.Text = Text;
            this.Value = Value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
