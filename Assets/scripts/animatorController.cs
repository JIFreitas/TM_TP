using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        // Obtém a referência para o componente Animator do personagem
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Verifica as entradas do jogador para determinar quais animações devem ser reproduzidas
        float moveInput = Input.GetAxisRaw("Horizontal");
        bool isMoving = Mathf.Abs(moveInput) > 0.1f;

        // Define os parâmetros do Animator conforme as entradas do jogador
        animator.SetBool("IsMoving", isMoving);

        // Se o jogador estiver a mover-se para a direita, inverte a escala do objeto
        if (moveInput > 0.1f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        // Se o jogador estiver a mover-se para a esquerda, inverte a escala do objeto
        else if (moveInput < -0.1f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }

        // Se o jogador pressionar a tecla de espaço, inicia a animação de salto
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Jump");
        }

        // Se o jogador pressionar a tecla de ataque (por exemplo, o botão esquerdo do mouse), inicia a animação de ataque
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Attack");
        }
    }
}
