namespace ObjectOrientedCollege
{
    // https://stackoverflow.com/questions/3063320/combobox-adding-text-and-value-to-an-item-no-binding-source
    class ComboboxGroupItem
    {
        public string Text { get; set; }
        public StudentGroup Value { get; set; }

        public ComboboxGroupItem(string Text, StudentGroup Value)
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
