using Contacts.Maui.Models;
using Contact = Contacts.Maui.Models.Contact;

namespace Contacts.Maui.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();

		List<Models.Contact> contacts = ContactRepository.GetContacts();

		listContacts.ItemsSource = contacts;
	}

	//private void BtnAddContact_OnClicked(object? sender, EventArgs e)
	//{
	//	Shell.Current.GoToAsync(nameof(AddContactPage));
	//}

	//private void BtnEditContact_OnClicked(object? sender, EventArgs e)
	//{
	//	Shell.Current.GoToAsync(nameof(EditContactPage));
	//}
	private async void ListContacts_OnItemSelected(object? sender, SelectedItemChangedEventArgs e)
	{
		//logic
		if (listContacts.SelectedItem != null)
		{
			DisplayAlert("test", "test", "OK");
			//await Shell.Current.GoToAsync(nameof(EditContactPage));
			await Shell.Current.GoToAsync($"{nameof(EditContactPage)}?Id={
				((Contact)listContacts.SelectedItem).ContactId
			}");
		}
	}

	private void ListContacts_OnItemTapped(object? sender, ItemTappedEventArgs e)
	{
		listContacts.SelectedItem = null;
	}
}