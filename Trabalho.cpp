// Matheus Oliveira 49668
// Matheus Trombini 48818
// Raphael Serra Oliveira 
// William Douglas Costa Gomes 48467

#include<bits/stdc++.h>
using namespace std;

// N�mero m�ximo de matrizes
#define MAX 10

// N�mero m�ximo de threads
#define MAX_THREAD 4

int matA[MAX][MAX];
int matB[MAX][MAX];
int matC[MAX][MAX];
int l1, c1, l2, c2, step_i = 0;

void* multi(void* arg)
{
	int i = step_i++; 

	for (int j = 0; j < MAX; j++)
		for (int k = 0; k < MAX; k++)
			matC[i][j] += matA[i][k] * matB[k][j];
}

int main()
{
	setlocale(LC_ALL, "Portuguese");
	cout << "Insira o n�mero de linhas e colunas da primeira matriz:\nLinhas: ";
	    cin >> l1;
	    cout << "Colunas: ";
	    cin >> c1;
	    cout << "Insira o n�mero de linhas e colunas da segunda matriz:\nLinhas: ";
	    cin >> l2;
	    cout << "Colunas: ";
	    cin >> c2;
	
	    // Se a n�mero de colunas da primeira matriz for diferente do n�mero de linhas da segunda,
	    while (c1!=l2)
	    {
	        cout << "Erro! O n�mero de colunas da primeira matriz n�o � igual ao n�mero de linhas da segunda matriz";
	
	        cout << "Insira o n�mero de linhas e colunas da primeira matriz:\nLinhas: ";
		    cin >> l1;
		    cout << "Colunas: ";
		    cin >> c1;
		    cout << "Insira o n�mero de linhas e colunas da segunda matriz:\nLinhas: ";
		    cin >> l2;
		    cout << "Colunas: ";
		    cin >> c2;
	    }
	
	    // Coleta os elementos da primeira matriz.
	    cout << endl << "Insira os elementos da primeira matriz" << endl;
	    for(int i = 0; i < l1; ++i)
	        for(int j = 0; j < c1; ++j)
	        {
	            cout << "Elemento " << i + 1 << j + 1 << " : ";
	            cin >> matA[i][j];
	        }
	
	    // Coleta os elementos da segunda matriz.
	    cout << endl << "Insira os elementos da segunda matriz" << endl;
	    for(int i = 0; i < l2; ++i)
	        for(int j = 0; j < c2; ++j)
	        {
	            cout << "Elemento " << i + 1 << j + 1 << " : ";
	            cin >> matB[i][j];
	        }
	
	    // Inicia os elementos da matriz com o valor 0
	    for(int i = 0; i < l1; ++i)
	        for(int j = 0; j < c2; ++j)
	        {
	            matC[i][j]=0;
	        }
	
		// Exibe a primeira matriz
		cout << endl
			<< "Matriz A" << endl;
		for (int i = 0; i < l1; i++) {
			for (int j = 0; j < c2; j++)
				cout << matA[i][j] << " ";
			cout << endl;
		}
	
		// Exibe a segunda matriz
		cout << endl
			<< "Matriz B" << endl;
		for (int i = 0; i < l1; i++) {
			for (int j = 0; j < c2; j++)
				cout << matB[i][j] << " ";	
			cout << endl;
		}
	
		// Declara��o de 4 threads
		pthread_t threads[MAX_THREAD];
	
		// Cria��o das threads e preenchimento dos dados
		for (int i = 0; i < MAX_THREAD; i++) {
			int* p;
			pthread_create(&threads[i], NULL, multi, (void*)(p));
		}
	
		// Aguarda finaliza��o de todas as threads
		for (int i = 0; i < MAX_THREAD; i++)
			pthread_join(threads[i], NULL);
	
		// Exibe a matriz resultante
		cout << endl
			<< "Multiplica��o da Matriz A e B" << endl;
		for (int i = 0; i < l1; i++) {
			for (int j = 0; j < c2; j++)
				cout << matC[i][j] << " ";	
			cout << endl;
		}
	return 0;
}
