namespace Notes.Views;

public partial class AllNotesPageSC : ContentPage
{
    public AllNotesPageSC()
    {
        InitializeComponent();
    }
    private void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
    {
        notesCollection.SelectedItem = null;
    }
}