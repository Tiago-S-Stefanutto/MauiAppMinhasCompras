namespace MauiAppMinhasCompras.Views;
using MauiAppMinhasCompras.Models;

public partial class EditarProduto : ContentPage
{
	public EditarProduto()
	{
		InitializeComponent();
	}
    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        try
        {
            Produto produto_anexado = BindingContext as Produto; // Cria uma vari�vel (tipo de produto) que ser� o nosso Binding Context --> Em outras palavras, ele far� a fun��o �ViewModel�, ligando o DB com a View

            Produto p = new Produto
            {
                Id = produto_anexado.Id,
                Descricao = txt_descricao.Text,
                Quantidade = Convert.ToDouble(txt_quantidade.Text),
                Preco = Convert.ToDouble(txt_preco.Text)
            }; // Inserir os valores dados numa nova inst�ncia de produtos

            await App.Db.Insert(p); // Atualizar o produto com novos valores
            await DisplayAlert("Sucesso!", "Registro Atualizado", "OK");
            await Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "Ok");
        }
    }
}