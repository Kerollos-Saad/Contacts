using Contacts.Maui.Models;

namespace Contacts.Maui.Views;

public partial class AddContactPage : ContentPage
{
	public AddContactPage()
	{
		InitializeComponent();
	}

	private void BtnCancel_OnClicked(object? sender, EventArgs e)
	{
		Shell.Current.GoToAsync("..");
	}

	private void ContactCtrl_OnSave(object? sender, EventArgs e)
	{
		ContactRepository.AddContact(new Models.Contact
		{
			Name = contactCtrl.Name,
			Email = contactCtrl.Email,
			Address = contactCtrl.Address,
			Phone = contactCtrl.Phone,
		});
		Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
	}

	private void ContactCtrl_OnError(object? sender, string e)
	{
		DisplayAlert("Error", e, "OK");
	}
}