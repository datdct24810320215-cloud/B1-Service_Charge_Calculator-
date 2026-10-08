namespace B1_Service_Charge_Calculator_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(textBoxPrice.Text) ||
                string.IsNullOrWhiteSpace(textBoxQuantity.Text) ||
                string.IsNullOrWhiteSpace(textBoxDiscount.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các ô số.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var culture = System.Globalization.CultureInfo.CurrentCulture;
            if (!decimal.TryParse(textBoxPrice.Text, System.Globalization.NumberStyles.Number, culture, out var price))
            {
                MessageBox.Show("Đơn giá không hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPrice.Focus();
                return;
            }

            if (!decimal.TryParse(textBoxQuantity.Text, System.Globalization.NumberStyles.Number, culture, out var quantity))
            {
                MessageBox.Show("Số lượng không hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxQuantity.Focus();
                return;
            }

            if (!decimal.TryParse(textBoxDiscount.Text, System.Globalization.NumberStyles.Number, culture, out var discount))
            {
                MessageBox.Show("Mã giảm giá không hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxDiscount.Focus();
                return;
            }

            if (price < 0 || quantity < 0 || discount < 0)
            {
                MessageBox.Show("Giá trị không được âm.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (discount > 100)
            {
                MessageBox.Show("% Giảm không được lớn hơn 100.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxDiscount.Focus();
                return;
            }

            // Calculate total: (price * quantity) * (100 - discount) / 100
            var total = (price * quantity) * (100 - discount) / 100;
            labelTotalValue.Text = total.ToString("N2", culture);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxPrice.Text = string.Empty;
            textBoxQuantity.Text = string.Empty;
            textBoxDiscount.Text = string.Empty;
            labelTotalValue.Text = 0m.ToString("N2");
            textBoxPrice.Focus();
        }
    }
}
