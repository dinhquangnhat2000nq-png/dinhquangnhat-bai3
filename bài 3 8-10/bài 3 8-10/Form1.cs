namespace bài_3_8_10
{
    public partial class Form1 : Form
    {
        private List<Item> items = new List<Item>();

        public Form1()
        {
            InitializeComponent();
        }

        private void RefreshListView()
        {
            listViewItems.Items.Clear();
            foreach (var it in items)
            {
                var lvi = new ListViewItem(it.Ma);
                lvi.SubItems.Add(it.Ten);
                lvi.SubItems.Add(it.DonVi);
                lvi.SubItems.Add(it.DonGia.ToString("N2"));
                listViewItems.Items.Add(lvi);
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            var ma = txtMa.Text.Trim();
            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show("Mã vật tư không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (items.Any(x => x.Ma.Equals(ma, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã vật tư đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtDonGia.Text.Trim(), out var donGia))
                donGia = 0;

            var item = new Item
            {
                Ma = ma,
                Ten = txtTen.Text.Trim(),
                DonVi = cboDonVi.SelectedItem?.ToString() ?? string.Empty,
                DonGia = donGia
            };
            items.Add(item);
            RefreshListView();
            ClearInputs();
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            if (listViewItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = listViewItems.SelectedItems[0];
            var maOld = selected.Text;

            var ma = txtMa.Text.Trim();
            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show("Mã vật tư không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // If changing code, ensure new code doesn't clash with existing other items
            if (!ma.Equals(maOld, StringComparison.OrdinalIgnoreCase) && items.Any(x => x.Ma.Equals(ma, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã vật tư đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var it = items.FirstOrDefault(x => x.Ma.Equals(maOld, StringComparison.OrdinalIgnoreCase));
            if (it != null)
            {
                it.Ma = ma;
                it.Ten = txtTen.Text.Trim();
                it.DonVi = cboDonVi.SelectedItem?.ToString() ?? string.Empty;
                if (!decimal.TryParse(txtDonGia.Text.Trim(), out var donGia))
                    donGia = 0;
                it.DonGia = donGia;
            }
            RefreshListView();
            ClearInputs();
        }

        private void BtnXoaDong_Click(object sender, EventArgs e)
        {
            if (listViewItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            var ma = listViewItems.SelectedItems[0].Text;
            items.RemoveAll(x => x.Ma.Equals(ma, StringComparison.OrdinalIgnoreCase));
            RefreshListView();
            ClearInputs();
        }

        private void BtnXoaToanBo_Click(object sender, EventArgs e)
        {
            if (items.Count == 0)
                return;
            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa toàn bộ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;
            items.Clear();
            RefreshListView();
            ClearInputs();
        }

        private void ListViewItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewItems.SelectedItems.Count == 0)
                return;
            var sel = listViewItems.SelectedItems[0];
            txtMa.Text = sel.SubItems[0].Text;
            txtTen.Text = sel.SubItems[1].Text;
            var dv = sel.SubItems[2].Text;
            if (!string.IsNullOrEmpty(dv))
            {
                cboDonVi.SelectedItem = cboDonVi.Items.Cast<object>().FirstOrDefault(x => x.ToString() == dv);
            }
            txtDonGia.Text = sel.SubItems[3].Text;
        }

        private void ClearInputs()
        {
            txtMa.Clear();
            txtTen.Clear();
            cboDonVi.SelectedIndex = -1;
            txtDonGia.Clear();
        }
    }
}
