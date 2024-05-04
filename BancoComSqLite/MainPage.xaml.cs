using BancoComSqLite.Modelos;
using BancoComSqLite.Repositorios;

namespace BancoComSqLite;

public partial class MainPage : ContentPage
{
	int count = 0;
    private PacienteRepositorio pacientes;

    public MainPage()
	{
		InitializeComponent();
		pacientes = new PacienteRepositorio(); 
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
		lista.ItemsSource = null;
		lista.ItemsSource = pacientes.listarTodos();
    }

    private void excluir_Clicked(object sender, EventArgs e)
    {
        // Buscar dados dos pacientes
        Paciente p = (Paciente)(sender as MenuItem).BindingContext;

        // Atualiza a exclusão dos dados do paciente
        Navigation.PushAsync(new Excluir(p.Id));
    }

    private void editar_Clicked(object sender, EventArgs e)
    {
        // Buscar dados dos pacientes
        Paciente p = (Paciente)(sender as MenuItem).BindingContext;
        
        // Atualiza a edição dos dados do paciente
        Navigation.PushAsync(new Editar(p.Id));
    }

    private void inserir_Clicked(object sender, EventArgs e)
    {
        // Busca os dados dos pacientes
        Paciente p = (Paciente)(sender as MenuItem).BindingContext;

        // Atualiza a inserção dos dados do paciente
        Navigation.PushAsync(new Inserir(p.Id));
    }
}

