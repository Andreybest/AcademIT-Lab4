namespace ObjectOrientedCollege
{
    // https://stackoverflow.com/questions/3063320/combobox-adding-text-and-value-to-an-item-no-binding-source
    class ComboboxAudienceItem
    {
        public string Text { get; set; }
        public Audience Value { get; set; }

        public ComboboxAudienceItem(string Text, Audience Value)
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
