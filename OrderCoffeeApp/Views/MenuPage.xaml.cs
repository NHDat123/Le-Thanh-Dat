using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Imaging;
using Microsoft.UI.Xaml.Navigation;
using OrderCoffeeApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace OrderCoffeeApp.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MenuPage : Page, INotifyPropertyChanged
    {
        public ObservableCollection<DrinkItem> Drinks { get; set; }
        public ObservableCollection<DrinkItem> Snacks { get; set; }
        public ObservableCollection<DrinkItem> CartItems { get; set; } = new ObservableCollection<DrinkItem>();
        public event PropertyChangedEventHandler PropertyChanged;
        public MenuPage()
        {
            this.InitializeComponent();
            this.DataContext = this;

            // Danh sách nước uống
            Drinks = new ObservableCollection<DrinkItem>
            {
                new DrinkItem { Name = "Cà phê đen", Price = "20.000đ", Image = "ms-appx:///Assets/blackcf.png", Quantity=0 },
                new DrinkItem { Name = "Cà phê sữa", Price = "25.000đ", Image = "ms-appx:///Assets/milkcf.png", Quantity=0 },
                new DrinkItem { Name = "Espresso", Price = "30.000đ", Image = "ms-appx:///Assets/espresso.png", Quantity=0 },
                new DrinkItem { Name = "Matcha Latte", Price = "50.000đ", Image = "ms-appx:///Assets/matchalatte.png", Quantity=0 },
                new DrinkItem { Name = "Trà sữa thái xanh", Price = "35.000đ", Image = "ms-appx:///Assets/milktea.png", Quantity=0 },
                new DrinkItem { Name = "Trà sữa khoai môn", Price = "35.000đ", Image = "ms-appx:///Assets/milkteakhoaimon.png", Quantity=0 },
                new DrinkItem { Name = "Hồng trà sữa", Price = "35.000đ", Image = "ms-appx:///Assets/hongtrasua.png", Quantity=0 },
                new DrinkItem { Name = "Trà đào", Price = "30.000đ", Image = "ms-appx:///Assets/tradao.png", Quantity=0 }
            };

            // Danh sách ăn vặt
            Snacks = new ObservableCollection<DrinkItem>
            {
                new DrinkItem { Name = "Bánh tráng nướng", Price = "10.000đ", Image = "ms-appx:///Assets/banhtrangnuong.jpg", Quantity=0 },
                new DrinkItem { Name = "Khoai tây chiên", Price = "20.000đ", Image = "ms-appx:///Assets/khoaitaychien.jpg", Quantity=0 },
                new DrinkItem { Name = "Bánh tráng trộn", Price = "15.000đ", Image = "ms-appx:///Assets/banhtrangtron.jpg", Quantity=0 },
                new DrinkItem { Name = "Cá viên chiên", Price = "50.000đ", Image = "ms-appx:///Assets/cavienchien.jpg", Quantity=0 },
                new DrinkItem { Name = "Bún bò Huế", Price = "3.000.000đ", Image = "ms-appx:///Assets/bunbohue.png", Quantity=0 },
                new DrinkItem { Name = "Tiramisuu", Price = "3.500.000đ", Image = "ms-appx:///Assets/tiramisuu.png", Quantity=0 }
            };
        }

        private void AddToCart_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var selectedItem = button?.Tag as DrinkItem;

            if (selectedItem != null && selectedItem.Quantity > 0)
            {
                // Kiểm tra món đã có trong giỏ chưa
                var existingItem = CartItems.FirstOrDefault(i => i.Name == selectedItem.Name);

                if (existingItem != null)
                {
                    existingItem.Quantity = selectedItem.Quantity;
                }
                else
                {
                    //CartItems.Add(new DrinkItem
                    //{
                    //    Name = selectedItem.Name,
                    //    Price = selectedItem.Price,
                    //    Image = selectedItem.Image,
                    //    Quantity = selectedItem.Quantity
                    //});
                    CartItems.Add(selectedItem);
                }

                //OnPropertyChanged(nameof(CartItems));
            }
        }

        private async void ConfirmOrder_Click(object sender, RoutedEventArgs e)
        {
            if (CartItems.Count == 0)
            {
                ContentDialog dialog = new ContentDialog
                {
                    Title = "Thông báo",
                    Content = "Giỏ hàng đang trống.",
                    CloseButtonText = "OK",
                    XamlRoot = this.XamlRoot
                };
                _ = dialog.ShowAsync();
                return;
            }

            double total = 0;
            foreach (var item in CartItems)
            {
                string cleanPrice = item.Price.Replace(".", "").Replace("đ", "");
                if (double.TryParse(cleanPrice, out double p))
                {
                    total += p * item.Quantity;
                }
            }

            ContentDialog confirmDialog = new ContentDialog
            {
                Title = "Xác nhận đặt hàng và thanh toán",
                Content = $"Tổng tiền: {total:N0}đ\nVui lòng chọn hình thức thanh toán:",
                PrimaryButtonText = "Tiền mặt",
                SecondaryButtonText = "Mã QR",
                CloseButtonText = "Hủy",
                XamlRoot = this.XamlRoot
            };

            var result = await confirmDialog.ShowAsync();
            
            if (result == ContentDialogResult.None) return;

            // Thanh toán
            if (result == ContentDialogResult.Primary)
            {
                // Tiền mặt
                ContentDialog paidDialog = new ContentDialog
                {
                    Title = "Thanh toán thành công",
                    Content = "Đã thanh toán bằng tiền mặt",
                    CloseButtonText = "OK",
                    XamlRoot = this.XamlRoot
                };
                await paidDialog.ShowAsync();
            }
            else if (result == ContentDialogResult.Secondary)
            {
                var dialog = new ContentDialog
                {
                    Title = "Quét mã QR để thanh toán",
                    CloseButtonText = "Đóng",
                    XamlRoot = this.XamlRoot,
                    Content = new ScrollViewer
                    {
                        Content = new Image
                        {
                            Source = new BitmapImage(new Uri("ms-appx:///Assets/QRCode.png")),
                            Width = 400,
                            HorizontalAlignment = Microsoft.UI.Xaml.HorizontalAlignment.Center
                        }
                    }
                };

                await dialog.ShowAsync();
            }

            // Tạo đơn hàng sau khi thanh toán
            var newOrder = new Order
            {
                Items = CartItems.Select(item => new DrinkItem
                {
                    Name = item.Name,
                    Price = item.Price,
                    Image = item.Image,
                    Quantity = item.Quantity,
                    Note = item.Note,
                }).ToList(),
                TotalAmount = total,
                CreatedTime = DateTime.Now,
                PaymentStatus = "Đã thanh toán"
            };

            // Thêm vào danh sách đơn đã đặt
            AppData.AllOrders.Add(newOrder);

            // Xóa giỏ hàng
            CartItems.Clear();
            OnPropertyChanged(nameof(CartItems));

            // Reset Quantity về 0 cho tất cả Drink và Snack
            foreach (var item in Drinks)
            {
                item.Quantity = 0;
            }
            foreach (var item in Snacks)
            {
                item.Quantity = 0;
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void NumberBox_ValueChanged(NumberBox sender, NumberBoxValueChangedEventArgs args)
        {
            if (double.IsNaN(sender.Value))
            {
                sender.Value = 0; // Gán lại giá trị mặc định
            }
        }

        private void CancelOrder_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var item = button?.Tag as DrinkItem;
            if (item != null && CartItems.Contains(item))
            {
                CartItems.Remove(item);
                OnPropertyChanged(nameof(CartItems));
            }
        }
    }
}
