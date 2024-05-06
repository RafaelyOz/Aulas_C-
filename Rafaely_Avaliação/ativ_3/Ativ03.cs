
//Program2.cs
//Sobrescrita
public class Animal {
    public virtual void EmitirSom() {
        Console.WriteLine("Som genérico do animal.");
    }
}

public class Vaca : Animal {
    public override void EmitirSom() {
        Console.WriteLine("Mu Mu Mu");
    }
}


//Sobrecarga
public class Cachorro{
    public string Nome{ get; set; }
    public string Raca{ get; set; }

    //constructor sem parâmetro
    public Cachorro(){
        Nome = "Totó";
        Raca = "Labrador";
    }

    //constructor com parâmetro para nome e raça
    public Cachorro(string Nome, string Raca){
        this.Nome = Nome;
        this.Raca = Raca;
    }

    public void ExibirDados(){
        Console.WriteLine($"Nome: {Nome}, Raça: {Raca}");
    }
}