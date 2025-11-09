using System.Collections.ObjectModel;
using Contacts.Maui.Models;
using Contact = Contacts.Maui.Models.Contact;

namespace Contacts.Maui.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();
	}

	private void LoadContacts()
	{
		var contacts = new ObservableCollection<Contact>(ContactRepository.GetContacts());
		listContacts.ItemsSource = contacts;
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();

		SearchBar.Text = string.Empty;

		LoadContacts();
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
			//DisplayAlert("test", "test", "OK");
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

	private void BtnAdd_OnClicked(object? sender, EventArgs e)
	{
		Shell.Current.GoToAsync(nameof(AddContactPage));
	}

	private void Delete_OnClicked(object? sender, EventArgs e)
	{
		var menuItem = sender as MenuItem;
		var contact = menuItem?.CommandParameter as Contact;

		ContactRepository.DeleteContact(contact.ContactId);
		LoadContacts();
	}

	private void SearchBar_TextChanged(object? sender, TextChangedEventArgs e)
	{
		var contacts = new ObservableCollection<Contact>(ContactRepository.SearchContacts(((SearchBar)sender).Text));
		listContacts.ItemsSource = contacts;
	}
}