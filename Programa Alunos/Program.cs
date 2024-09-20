using System;

class Program{
    static void MediaAlunos (string[] alunos , double[,] notas ){
        double[] media = new double [10];   
        double[] soma = new double [10];   


        for(int i = 0 ; i < notas.GetLength(0) ; i++){
            for(int j = 0 ; j < notas.GetLength(1) ; j++){
                soma[i] += notas[i,j];
                
            }
            media[i] += soma[i]/3;
        }
        for(int i = 0 ; i < notas.GetLength(0) ; i++){
            Console.WriteLine(media[i] >= 7 ? $"Media Do Aluno {alunos[i]} = {media[i]:N1} Aprovado" : $"Media Do Aluno {alunos[i]} = {media[i]:N1} Reprovado");
        }
    }

    static double[,] LerNotas(string[] alunos , double[,] notas )
    {
        for(int i = 0 ; i < notas.GetLength(0) ; i++){
            for(int j = 0 ; j < notas.GetLength(1) ; j++){
                Console.WriteLine($"Digite As Notas do Aluno {alunos[i]} : ");
                notas[i,j]=Convert.ToDouble(Console.ReadLine());
            }
            Console.Clear();
        }
        Console.Clear();
        return notas;

    }

    static string[] LerAlunos(string[] alunos){

        for(int i = 0 ; i < alunos.GetLength(0) ; i++)
        {
            Console.WriteLine($"Digite o Nome do Aluno  | {i+1} / {alunos.GetLength(0)}");
            alunos[i]= Console.ReadLine();

        }
        Console.Clear();
        return alunos;

    }
    public static void Main(string[] args)
    {
        string[] alunos = new string[5];
        double[,] notas = new double [5,3];
        
        LerAlunos(alunos);
        notas = LerNotas(alunos , notas);
        MediaAlunos(alunos , notas );


    }

}