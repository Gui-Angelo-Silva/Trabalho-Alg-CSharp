using System;

class AumentarNota
{
    static void Main()
    {
        //---------------Vetor---------------

        //Exercicio 1
        //int[] vet = new int[10];

        //Console.WriteLine("-----Insira os valores-----");

        //int i;

        //for (i = 0; i < 10; i++)
        //{
        //    vet[i] = Convert.ToInt32(Console.ReadLine());
        //}

        //Console.WriteLine("------Ordem crescente------");

        //for (i = 0; i < 10; i++)
        //{
        //    Console.WriteLine("  " + vet[i]);
        //}

        //Console.WriteLine("-----Ordem decrescente-----");

        //for (i = 9; i > -1; i--)
        //{
        //    Console.WriteLine("  " + vet[i]);
        //}


        //Exercicio2
        //int[] vet = new int[10];

        //Console.WriteLine("-----Insira os valores-----");

        //int i;

        //for (i = 0; i < 10; i++)
        //{
        //    vet[i] = Convert.ToInt32(Console.ReadLine());
        //}

        //Console.WriteLine("-------Ordem inversa-------");

        //for (i = 9; i > -1; i--)
        //{
        //    Console.WriteLine("  " + vet[i]);
        //}

        //Exercicio3
        //int[] vet = new int[10];
        //int[] vetT = new int[10];

        //// ler o vetor original
        //Console.WriteLine("Digite 10 números inteiros e positivos:");

        //for (int i = 0; i < 10; i++)
        //{
        //    vet[i] = Convert.ToInt32(Console.ReadLine());
        //}

        //Console.Write("\nVetor original: ");
        //for (int i = 0; i < 10; i++)
        //{
        //    Console.Write(vet[i] + " ");
        //}

        //for (int i = 0; i < 10; i++)
        //{
        //    if (i % 2 == 0)
        //    {
        //        vetT[i] = vet[i] / 2;
        //    }
        //    else if(i % 2 != 0)
        //    {
        //        vetT[i] = vet[i] * 3;
        //    }
        //}
        //Console.Write("\nVetor transformado: ");
        //for (int i = 0; i < 10; i++)
        //{
        //    Console.Write(vetT[i] + " ");

        //Exercicio 5

        //int [] vetP = new int[20];
        //int [] vetS = new int[20];
        //int [] vetDiferenca = new int[20];
        //int [] vetSoma = new int[20];
        //int [] vetMultiplicacao = new int[20];

        //Console.WriteLine("Informe números para o primeiro vetor e o segundo");

        //for (int i = 0; i < 20; i++)
        //{
        //    vetP[i] = Convert.ToInt32(Console.ReadLine());
        //}

        //for (int i = 0; i < 20; i++)
        //{
        //    vetS[i] = Convert.ToInt32(Console.ReadLine());
        //}

        //for (int i = 0; i < 20; i++)
        //{
        //    vetDiferenca[i] = vetP[i] - vetS[i];
        //}

        //for (int i = 0; i < 20; i++)
        //{
        //    vetSoma[i] = vetP[i] + vetS[i];
        //}

        //for (int i = 0; i < 20; i++)
        //{
        //    vetMultiplicacao[i] = vetP[i] * vetS[i];
        //}

        //Console.WriteLine("Diferença");

        //for (int i = 0; i < 20; i++)
        //{
        //    Console.WriteLine("  " + vetDiferenca[i]);
        //}

        //Console.WriteLine("Soma");

        //for (int i = 0; i < 20; i++)
        //{
        //    Console.WriteLine("  " + vetSoma[i]);
        //}

        //Console.WriteLine("Multiplicacao");

        //for (int i = 0; i < 20; i++)
        //{
        //    Console.WriteLine("  " + vetMultiplicacao[i]);
        //}

        //Exercicio 6 - Mais ou menos certo

        //int[] vet = new int[6];
        //int[] vetNumPar = new int[6];
        //int[] vetNumImpar = new int[6];

        //Console.WriteLine("Informe 6 números: ");

        //for (int i = 0; i < 6; i++)
        //{
        //    vet[i] = Convert.ToInt32(Console.ReadLine());
        //}

        //for (int i = 0; i < 6; i++)
        //{
        //    Console.WriteLine(vet[i] + "");
        //}

        //for (int i = 0; i < 6; i++)
        //{
        //    if (vet[i] % 2 == 0)
        //    {
        //        vetNumPar[i] = vet[i];
        //    }
        //    else if (vet[i] % 2 != 0)
        //    {
        //        vetNumImpar[i] = vet[i];
        //    }
        //}

        //for (int i = 0; i < 3; i++)
        //{
        //    Console.WriteLine(vetNumPar[i] + "");
        //}

        //for (int i = 0; i < 3; i++)
        //{
        //    Console.WriteLine(vetNumImpar[i] + "");
        //}

        //Exercicio 7 - Mais ou menos

        //int[] vetP = new int[4];
        //int[] vetS = new int[4];
        //int i;

        //Console.WriteLine("Preencha o vetor 1");

        //for (i = 0; i < 4; i++)
        //{
        //    vetP[i] = Convert.ToInt32(Console.ReadLine());
        //}

        //Console.WriteLine("Preencha o vetor 1");

        //for (i = 0; i < 4; i++)
        //{
        //    vetP[i] = Convert.ToInt32(Console.ReadLine());
        //}

        //for (i = 0; i < 4; i++)
        //{
        //    if (vetP[i] == vetS[i])
        //    {
        //        Console.WriteLine("São iguais!");
        //    }

        //    else if (vetP[i] != vetS[i])
        //    {
        //        Console.WriteLine("São diferentes!");
        //    }
        //}

        //---------------Matriz---------------

        //Exercicio 1
        //int[,] mat = new int[10, 315];
        //int l, c;
        //int somaLinha = 0;
        //int somaColuna = 0;

        //Console.WriteLine("Informe 9 valores para completar a matriz");

        //for (l = 0; l < 10; l++)
        //{
        //    for (c = 0; c < 15; c++)
        //    {
        //        Console.WriteLine("Informe o valor do indice..... " + l + " , " + c);
        //        mat[l, c] = Convert.ToInt32(Console.ReadLine());
        //    }
        //}

        //for (l = 0; l < 10; l++)
        //{
        //    somaLinha = 0;
        //    for (c = 0; c < 15; c++)
        //    {
        //        somaLinha += mat[l, c];
        //    }
        //    if (somaLinha % 2 == 0)
        //    {
        //        Console.WriteLine("A soma das linhas é: " + somaLinha + " - PAR!");
        //    }
        //    else if (somaLinha % 2 != 0)
        //    {
        //        Console.WriteLine("A soma das linhas é: " + somaLinha + " - ÍMPAR!");
        //    }
        //}

        //for (c = 0; c < 15; c++)
        //{
        //    somaColuna = 0;

        //    for (l = 0; l < 10; l++)
        //    {
        //        somaColuna += mat[l, c];
        //    }
        //    if (somaColuna % 2 == 0)
        //    {
        //        Console.WriteLine("A soma das colunas é: " + somaColuna + " - PAR!");
        //    }
        //    else if (somaColuna % 2 != 0)
        //    {
        //        Console.WriteLine("A soma das colunas é: " + somaColuna + " - ÍMPAR!");
        //    }
        //}

        //Exercicio 2

        //int[,] mat = new int[50, 50];
        //int[] vetD = new int[50];
        //int l, c;

        //for (l = 0; l < 50; l++)
        //{
        //    for (c = 0; c < 50; c++)
        //    {
        //        Console.WriteLine("Informe o valor do indice..... " + l + " , " + c);
        //        mat[l, c] = Convert.ToInt32(Console.ReadLine());
        //    }
        //}

        //Console.WriteLine("Elementos da diagonal principal: ");

        //for (l = 0; l < 50; l++)
        //{
        //    for (c = 0; c < 50; c++)
        //    {
        //        if (l == c)
        //        {
        //            vetD[c] = mat[l, c];
        //            Console.WriteLine(vetD[c]);
        //        }
        //    }
        //}

        //Exercicio 3

        //int[,] mat = new int[3, 3];
        //int[,] transposta = new int[3, 3];
        //int l, c;

        //for (l = 0; l < 3; l++)
        //{
        //    for (c = 0; c < 3; c++)
        //    {
        //        Console.WriteLine("Informe o valor do indice..... " + l + " , " + c);
        //        mat[l, c] = Convert.ToInt32(Console.ReadLine());
        //    }
        //}

        //for (l = 0; l < 3; l++)
        //{
        //    for (c = 0; c < 3; c++)
        //    {
        //        transposta[c, l] = mat[l, c];
        //    }
        //}

        //Console.WriteLine("Matriz Transposta");

        //for (l = 0; l < 3; l++)
        //{
        //    for (c = 0; c < 3; c++)
        //    {
        //        Console.WriteLine(transposta[l, c]);
        //    }
        //}

        //Exercicio 4

        //int[,] matP = new int[3, 3];
        //int[,] matS = new int[3, 3];
        //int[,] matR = new int[3, 3];
        //int l, c;

        //Console.WriteLine(" ----------Primeira Matriz----------");
        //for (l = 0; l < 3; l++)
        //{
        //    for (c = 0; c < 3; c++)
        //    {
        //        Console.WriteLine("Informe o valor do indice..... " + l + " , " + c);
        //        matP[l, c] = Convert.ToInt32(Console.ReadLine());
        //    }
        //}

        //Console.WriteLine("\n ----------Segunda Matriz-----------");

        //for (l = 0; l < 3; l++)
        //{
        //    for (c = 0; c < 3; c++)
        //    {
        //        Console.WriteLine("Informe o valor do indice..... " + l + " , " + c);
        //        matS[l, c] = Convert.ToInt32(Console.ReadLine());
        //    }
        //}

        //for (l = 0; l < 3; l++)
        //{
        //    for (c = 0; c < 3; c++)
        //    {
        //        matR[l, c] = matP[l, c] * matS[l, c];
        //    }
        //}

        //Console.WriteLine("\n -------Resultado Multiplicação-------");

        //for (l = 0; l < 3; l++)
        //{
        //    for (c = 0; c < 3; c++)
        //    {
        //        Console.WriteLine(matP[l, c] + " X " + matS[l, c] + " = " + matR[l, c]);
        //    }
        //}

        //Exercicio 5

        //int[,] matP = new int[3, 3];
        //int[,] matS = new int[3, 3];
        //int[,] matR = new int[3, 3];
        //int l, c;

        //Console.WriteLine(" ----------Primeira Matriz----------");
        //for (l = 0; l < 3; l++)
        //{
        //    for (c = 0; c < 3; c++)
        //    {
        //        Console.WriteLine("Informe o valor do indice..... " + l + " , " + c);
        //        matP[l, c] = Convert.ToInt32(Console.ReadLine());
        //    }
        //}

        //Console.WriteLine("\n ----------Segunda Matriz-----------");

        //for (l = 0; l < 3; l++)
        //{
        //    for (c = 0; c < 3; c++)
        //    {
        //        Console.WriteLine("Informe o valor do indice..... " + l + " , " + c);
        //        matS[l, c] = Convert.ToInt32(Console.ReadLine());
        //    }
        //}

        //for (l = 0; l < 3; l++)
        //{
        //    for (c = 0; c < 3; c++)
        //    {
        //        matR[l, c] = matP[l, c] + matS[l, c];
        //    }
        //}

        //Console.WriteLine("\n -------Resultado Multiplicação-------");

        //for (l = 0; l < 3; l++)
        //{
        //    for (c = 0; c < 3; c++)
        //    {
        //        Console.WriteLine(matP[l, c] + " + " + matS[l, c] + " = " + matR[l, c]);
        //    }
        //}

        //Exercicio 6

        //    int[,] mat = new int[4, 4];
        //    int n;

        //    for (int l = 0; l < 4; l++)
        //    {
        //        for (int c = 0; c < 4; c++)
        //        {
        //            Console.WriteLine("Informe o valor do indice..... " + l + " , " + c);
        //            mat[l, c] = Convert.ToInt32(Console.ReadLine());
        //        }
        //    }

        //    for (int i = 0; ; i++)
        //    {
        //        Console.WriteLine("-----------Menu-----------");
        //        Console.WriteLine("[1] - Mostrar Matriz");
        //        Console.WriteLine("[2] - Somar os quadrados de todos os elementos da primeira coluna");
        //        Console.WriteLine("[3] - Somar todos os elementos da terceira linha");
        //        Console.WriteLine("[4] - Somar os elementos da diagonal principal");
        //        Console.WriteLine("[5] - Somar todos os elementos de índice par da segunda linha");
        //        Console.WriteLine("[0] - Sair");
        //        n = Convert.ToInt32(Console.ReadLine());

        //        if (n == 0)
        //        {

        //        }

        //        if (n == 1)
        //        {
        //            Console.WriteLine("----------Matriz----------");
        //            ImprimeMatriz(mat);
        //        }

        //        if (n == 2)
        //        {
        //            SomaQuadrado(mat);
        //        }

        //        if (n == 3)
        //        {
        //            SomaTerceiraLinha(mat);
        //        }

        //        if (n == 4)
        //        {
        //            SomaDiagonalPrincipal(mat);
        //        }

        //        if (n == 5)
        //        {
        //            SomaElementosIndiceParSegundaLinha(mat);
        //        }
        //    }
        //}

        //static void ImprimeMatriz(int[,] mat)
        //{
        //    for (int l = 0; l < 4; l++)
        //    {
        //        for (int c = 0; c < 4; c++)
        //        {
        //            Console.Write(mat[l, c] + "\t");
        //        }
        //        Console.WriteLine("\n");
        //    }
        //}

        //static void SomaQuadrado(int[,] mat)
        //{
        //    int soma = 0;
        //    for (int l = 0; l < 4; l++)
        //    {
        //        soma += (int)Math.Pow(mat[l, 0], 2);
        //    }
        //    Console.WriteLine("\nA soma ao quadrado da primeira linha é: " + soma);
        //}

        //static void SomaTerceiraLinha(int[,] matriz)
        //{
        //    int soma = 0;
        //    for (int i = 0; i < 4; i++)
        //    {
        //        soma += matriz[2, i];
        //    }
        //    Console.WriteLine(soma);
        //}

        //static void SomaDiagonalPrincipal(int[,] matriz)
        //{
        //    int soma = 0;
        //    for (int i = 0; i < 4; i++)
        //    {
        //        soma += matriz[i, i];
        //    }
        //    Console.WriteLine(soma);
        //}

        //static void SomaElementosIndiceParSegundaLinha(int[,] matriz)
        //{
        //    int soma = 0;
        //    for (int i = 0; i < 4; i += 2)
        //    {
        //        soma += matriz[1, i];
        //    }
        //    Console.WriteLine(soma);
        //}
    }
}