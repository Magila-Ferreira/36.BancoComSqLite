using BancoComSqLite.Modelos;
using BancoComSqLite.Repositorios;

namespace BancoComSqLite;

public partial class Inserir : ContentPage
{
	private PacienteRepositorio _pacientes;
	public Inserir()
	{
		_pacientes = new PacienteRepositorio();
		InitializeComponent();
	}

	public Inserir(long id) : this() {
		Paciente p = new Paciente(); // Rever
		BindingContext = p;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		_pacientes.inserir(BindingContext as Paciente);
		Navigation.PopAsync();
    }
}