# Examen_FDV Manuel Hernández Padrón 28/01/2020 ULL Desarrollo de Videojuegos

El proyecto falta por finalizar y además exiten errores que no me dió tiempo a corergir.

1) El sprite de Susan no se ve, porque aunque corrijo la posición para que esté delante de la cámara, cuando construí la animación 
utilicé el record de su mal posicionado transform. Por lo tanto, aun corrigiéndolo, se mueve segun su animación a la mala posición.

2) Los sprites de las lápidas tampoco se ven, pero sí que suman puntos de energía la player y además colisionan con su collider.

3) El trigger final que cambia a la escena del menú está por terminar. Habría que crear una UI con una imagen y un texto como "Enhorabuena! 
has completado el nivel." Luego añaadirle un evento en la animación para que cargue la escena del menú.

4) El collider de las caidas del player, debería llevar el transform de mi jugador a la posición inicial, ya que le resta -100 a su energía.
Cometí el fallo de que en el script PowerManager el poder no disminuyera de 0 (variable minPower). En el método "Respawn" del player especifica 
que su transform se mueve a la posición original solo si la energía es igual o menor a -1. Por eso el respawn nunca funciona.

