namespace Clock_WPF.Models
{
    class Item
    {
        public string Text { get; set; }
        public double Angle { get; set; }
        public double ReverseAngle { get { return -this.Angle; } }

    }
}
