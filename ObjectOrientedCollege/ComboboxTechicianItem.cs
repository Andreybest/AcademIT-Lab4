namespace ObjectOrientedCollege
{
    // https://stackoverflow.com/questions/3063320/combobox-adding-text-and-value-to-an-item-no-binding-source
    class ComboboxTechicianItem
    {
        public string Text { get; set; }
        public Technician Value { get; set; }
        
        public ComboboxTechicianItem(string Text, Technician Value)
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
