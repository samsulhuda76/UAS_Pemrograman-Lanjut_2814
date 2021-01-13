# Study Case Apps
Aplikasi sederhana sebuah toko pada Study Kasus (Tugas UAS). Aplikasi ini berfungsi untuk simulasi pembelian baik makanan minuman dan dapat mengaplikasikan voucher yang tersedia serta customer dapat melihat menu dan promo yang tersedia.

## Scope & Functionalities
- User dapat memasukkan atau menghapus makanan pilihan ke dalam keranjang
- User dapat melihat subtotal makanan yang terdapat pada keranjang
- User dapat melihat daftar voucher yang ditawarkan
- User dapat menggunakan salah satu voucher
- User dapat melihat harga total termasuk potongannya

## How Does it works?

1. Model yang digunakan yaitu model item untuk makanan atau minuman, model keranjangBelanja untuk menaruh pembelian, model payment untuk mengurusi total harga beli, dan model Voucher untuk daftar vouchernya
2. Fungsi MainWindowController.cs digunakan untuk melakukan beberapa operasi. Seperti menambahkan item dan voucher, menghapus item dan voucher, lalu untuk mendapatkan data list dari item yang dibeli dan voucher yang digunakan.
3. Alur programnya dimulai dari `Menu.xaml.cs`, disini dibuat object item dan akan ditambahkan pada sebuah list, yang nantinya akan ditampilkan pada sebuah listbox.

``` C#
private void generateContentMenu()
        {
            Item Menu1 = new Item("Coffe Late", 30000);
            Item Menu2 = new Item("Black Tea", 20000);
            Item Menu3 = new Item("Pizza", 75000);
            Item Menu4 = new Item("Milk Shake", 15000);
            Item Menu5 = new Item("Fried Frice Special", 45000);
            Item Menu6 = new Item("Watermelon Juice", 25000);
            Item Menu7 = new Item("Lemon Squash", 30000);
            menuController.addItem(Menu1);
            menuController.addItem(Menu2);
            menuController.addItem(Menu3);
            menuController.addItem(Menu4);
            menuController.addItem(Menu5);
            menuController.addItem(Menu6);
            menuController.addItem(Menu7);
            listMenu.Items.Refresh();
        }
```

Pada `Voucher.xaml.cs`, disini fungsinya sama dengan `Menu.xaml.cs`. Kita membuat object voucher dari model Voucher tadi, dan dimasukkan kedalam list serta ditampilkan pada listbox.

```C++
private void generateContentPromo()
        {
            Diskon diskon1 = new Diskon("Promo Awal tahun Diskon 25 % ", 25000);
            Diskon diskon2 = new Diskon("Promo Tebus Murah Diskon 30 % atau maksimal 30.000", 30000);
            Diskon diskon3 = new Diskon("Promo Natal Potongan 10000", 10000);
            promoController.addPromo(diskon1);
            promoController.addPromo(diskon2);
            promoController.addPromo(diskon3);
            listBoxDaftarPromo.Items.Refresh();
        }
```

Lalu pada `MainWindow.xaml.cs` terdapat inisialisasi dan membuat beberapa instance. Kita membuat instance dari payment yang akan digunakan pada keranjangBelanja. Nah keranjangBelanja ini juga akan digunakan pada MainWindowController.

``` C#
public MainWindow()
        {
            InitializeComponent();
            payment = new Payment(this);
            KeranjangBelanja keranjangBelanja = new KeranjangBelanja(payment, this);
            controller = new MainWindowController(keranjangBelanja, payment);
            listKeranjangBelanja.ItemsSource = controller.getItems();
            listPromo.ItemsSource = controller.getDiskon();
            initializeView();
        }
```

Selain itu juga dibuatkan 2 baris kode untuk memasukkan data list item dan voucher ke masing - masing listbox. Selain pembuatan instance juga terdapat beberapa operasi yang dilakukan.

Nama: Samsul Huda
NIM: 19.11.2814
