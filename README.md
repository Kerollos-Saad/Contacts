# 📱 Contacts - .NET MAUI Application

A simple, cross-platform contacts management application built with .NET MAUI 9.0 (Multi-platform App UI). This application demonstrates how to create, view, edit, and manage contacts across Android, iOS, macOS, and Windows platforms using a single shared codebase.

## ✨ Features

- 📋 **View All Contacts**: Display a list of all saved contacts
- ➕ **Add New Contacts**: Create new contact entries with details
- ✏️ **Edit Contacts**: Update existing contact information
- 🗑️ **Delete Contacts**: Remove unwanted contacts
- 📱 **Cross-Platform**: Works on Android, iOS, macOS, and Windows
- 🎨 **Modern UI**: Clean and intuitive user interface with custom controls
- 💾 **Local Storage**: Contacts stored locally on device
- 🛠️ **MAUI Community Toolkit**: Enhanced UI capabilities

## 🚀 Technologies Used

- **.NET 9.0 MAUI** - Latest cross-platform framework
- **C#** - Programming language
- **XAML** - UI markup language
- **MVVM Pattern** - Architecture pattern
- **CommunityToolkit.Maui** - Additional MAUI components and helpers
- **Microsoft.Maui.Controls** - Core MAUI controls

## 📋 Prerequisites

Before you begin, ensure you have the following installed:

- [Visual Studio 2022](https://visualstudio.microsoft.com/) (version 17.8 or later) with the .NET MAUI workload
- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- For Android development: Android SDK (API 21 or higher)
- For iOS/macOS development: Xcode 15.0+ (macOS only)
- For Windows development: Windows 10 version 1809 or higher

## 🛠️ Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/Kerollos-Saad/Contacts.git
   cd Contacts
   ```

2. **Open the solution**
   - Open `Contacts.sln` in Visual Studio 2022

3. **Restore NuGet packages**
   ```bash
   dotnet restore
   ```

4. **Build the solution**
   ```bash
   dotnet build
   ```

## ▶️ Running the Application

### Visual Studio 2022

1. Select your target platform from the debug dropdown (Android, iOS, Windows, or macOS Catalyst)
2. Choose your device or emulator
3. Press `F5` or click the "Run" button

### Command Line

**For Android:**
```bash
dotnet build -t:Run -f net9.0-android
```

**For iOS:**
```bash
dotnet build -t:Run -f net9.0-ios
```

**For Windows:**
```bash
dotnet build -t:Run -f net9.0-windows10.0.19041.0
```

**For macOS Catalyst:**
```bash
dotnet build -t:Run -f net9.0-maccatalyst
```

## 📁 Project Structure

```
Contacts/
├── Contacts.Maui/           # Main MAUI project
│   ├── Views/               # XAML pages and UI
│   │   ├── ContactsPage.xaml         # Main contacts list page
│   │   ├── AddContactPage.xaml       # Add new contact page
│   │   ├── EditContactPage.xaml      # Edit contact page
│   │   └── Controls/                 # Custom controls
│   │       └── ContactControl.xaml   # Reusable contact control
│   ├── ViewModels/          # View models (if applicable)
│   ├── Models/              # Data models
│   ├── Services/            # Business logic and data services
│   ├── Platforms/           # Platform-specific code
│   │   ├── Android/
│   │   ├── iOS/
│   │   ├── MacCatalyst/
│   │   └── Windows/
│   ├── Resources/           # App resources
│   │   ├── AppIcon/         # Application icon
│   │   ├── Splash/          # Splash screen
│   │   ├── Images/          # Image assets
│   │   ├── Fonts/           # Custom fonts
│   │   └── Raw/             # Raw assets
│   ├── App.xaml             # Application entry point
│   ├── AppShell.xaml        # Application shell (navigation)
│   └── MauiProgram.cs       # App configuration
└── Contacts.Maui.csproj     # Project file
```

## 🔧 Platform Support

| Platform | Minimum Version | Status |
|----------|----------------|--------|
| Android | API 21 (Android 5.0) | ✅ Supported |
| iOS | 15.0+ | ✅ Supported |
| macOS (Catalyst) | 15.0+ | ✅ Supported |
| Windows | 10.0.17763.0+ | ✅ Supported |

## 📦 NuGet Packages

- **CommunityToolkit.Maui** (v9.0.3) - Extended MAUI controls and utilities
- **Microsoft.Maui.Controls** - Core MAUI framework
- **Microsoft.Extensions.Logging.Debug** (v9.0.0) - Debugging and logging support

## 🔑 Key Features Demonstrated

- **MVVM Architecture**: Separation of concerns between UI and business logic
- **XAML Custom Controls**: Reusable `ContactControl` component
- **Multi-Page Navigation**: Dedicated pages for viewing, adding, and editing contacts
- **Platform-Specific Code**: Handling platform differences seamlessly
- **Resource Management**: Organized app icons, splash screens, and assets
- **Community Toolkit Integration**: Leveraging extended MAUI capabilities

## 🎯 Usage

### Viewing Contacts
- Launch the app to see the main contacts list on `ContactsPage`
- Contacts are displayed using the custom `ContactControl`

### Adding a Contact
1. Navigate to the "Add Contact" page
2. Fill in the contact details (Name, Phone, Email, etc.)
3. Click "Save" to store the contact

### Editing a Contact
1. Select a contact from the list
2. Navigate to the "Edit Contact" page
3. Modify the desired fields
4. Click "Update" to save changes

### Deleting a Contact
1. Select a contact from the list
2. Use the delete option (swipe or button)
3. Confirm the deletion

## 🏗️ Building from Source

```bash
# Clone the repository
git clone https://github.com/Kerollos-Saad/Contacts.git

# Navigate to the project directory
cd Contacts/Contacts.Maui

# Restore dependencies
dotnet restore

# Build for specific platform
dotnet build -f net9.0-android    # For Android
dotnet build -f net9.0-ios        # For iOS
dotnet build -f net9.0-maccatalyst # For macOS
dotnet build -f net9.0-windows10.0.19041.0 # For Windows
```

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

1. Fork the project
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 👨‍💻 Author

**Kerollos Saad**
- GitHub: [@Kerollos-Saad](https://github.com/Kerollos-Saad)

## 📞 Support

If you have any questions or need help, please:
- Open an issue in this repository
- Contact me through GitHub

## 🙏 Acknowledgments

- [.NET MAUI Documentation](https://docs.microsoft.com/dotnet/maui/)
- [.NET MAUI Community Toolkit](https://learn.microsoft.com/dotnet/communitytoolkit/maui/)
- [Microsoft Learn - .NET MAUI](https://learn.microsoft.com/training/paths/build-apps-with-dotnet-maui/)
- The .NET MAUI Community

## 📸 Screenshots

<!-- Add screenshots of your application here -->

| Contacts List | Edit Contact | Search Contact |
|:-------------:|:-----------:|:------------:|
| ![Contacts List](https://github.com/user-attachments/assets/870d180c-5a79-4b70-ab4a-4958044672af) | ![Add Contact](https://github.com/user-attachments/assets/2ee748f2-2aea-4061-8176-e1e20f523065) | ![Edit Contact](https://github.com/user-attachments/assets/c071135b-ad8a-4935-a796-5f7c50ba8da4) |
---

⭐ If you find this project useful, please consider giving it a star!

## 🔄 Version History

- **v1.0** - Initial release
  - Basic CRUD operations for contacts
  - Cross-platform support (Android, iOS, macOS, Windows)
  - Custom contact control
  - .NET 9.0 MAUI implementation
