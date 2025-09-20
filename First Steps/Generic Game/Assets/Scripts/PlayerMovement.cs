using UnityEngine;
//using → serve para importar bibliotecas, assim como o import do jav.
//UnityEngine → é a biblioteca principal do Unity, onde estão as classes como: GameObject, MonoBehaviour, Transform, Rigidbody2D, etc.

public class PlayerMovement : MonoBehaviour
{
    //public → é um modificador de acesso. Exemplos: public, private, protected.
    //class → palavra reservada para criar uma classe em C#.
    //PlayerMoviment → é o nome da sua classe. Mesmo nome do script.
    // : Significa que a classe PlayerMovement herda todos os atributos funçoes da classe a seguir, neste caso, o MonoBehaviour.
    //MonoBehaviour → permite que um script se torne um componente do Unity, podendo ser adicionado a GameObjects e reagir a eventos da cena.  

    float speed = 15f;
    //Declaração da variável "speed" do tipo float
    //5f → Valor da velocidade de movimento

    void Update()
    {
        // O Update() é um dos métodos do ciclo de vida do MonoBehaviour.
        // Ele faz com que a Unity atualize o comportamento do objeto a cada frame.

        float move = Input.GetAxis("Horizontal");
        //float → tipo da variáveil
        //move → nome da variáveil
        //Input → classe da UnityEngine que capturar entradas do jogador (teclado, mouse, joystick, touch etc.).
        //GetAxis() → Método da classe Input onde declaramos qual eixo queremos capturar, "Horizontal" ou "Vertical".

        transform.Translate(Vector2.right * move * Time.deltaTime * speed);
        //transform → chama diretamente o transform, que pode ser visto no inspector (posição, rotação, escala).
        //Translate() → método do transform que move o objeto (soma um vetor à sua posição atual).
        //Vector2 → Vector2 é um tipo de variavel do C# no Unity, que representa um vetor de duas Dimensões (Direção e Magnitude da deslocação).
        //right → determinha que movimentções a direita serão respresentadas por numeros positivos no vetor. E left, negativos.
        //move → a variável com Input.GetAxis() que captura a entrada do jogador.
        //Time → classe do Unity que fornece informações sobre o tempo do jogo.
        //deltaTime → calcula o tempo que passou desde o último frame, em segundos.
        //speed → Variável que determina a velocidade de movimentação do objeto.
	} 
}
