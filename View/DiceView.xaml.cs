namespace MysticPartyTracker.View;
using MysticPartyTracker.Models;

public partial class DiceView : ContentPage
{
	public DiceView()
	{
		InitializeComponent();

	}

    private void rollardadosButton_Clicked(object sender, EventArgs e)
    {
		int lados = Convert.ToInt32(PickerLados.SelectedItem.ToString());
		int dados = Convert.ToInt32(PickerDados.SelectedItem.ToString());
		Dice dice = new Dice(lados);
		ValueDice.Text = "";


        for (int i = 0; i < dados; i++)
		{
			ValueDice.Text = ValueDice.Text + ", " + dice.Rolar().ToString();

		}


    }
}