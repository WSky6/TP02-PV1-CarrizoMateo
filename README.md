### <h1>Parkour 3D: \[Red.Jr]</h1>

### <h2>Datos del Proyecto</h2>

### <p><strong>Asignatura:</strong> Programación de Videojuegos I</p>

### <p><strong>Carrera:</strong> Tecnicatura Universitaria en Diseño Integral de Videojuegos (TUDIVJ) - UNJu</p>

### <p><strong>Trabajo Práctico N° 1:</strong> Entorno Interactivo 3D, Temporizadores y Git/GitHub</p>

### <p><strong>Estudiante:</strong> Mateo Ricardo Carrizo</p>

### <p><strong>LU:</strong> \[TUV000877]</p>

### <p><strong>Equipo Docente:</strong></p>

### <ul>

### <li>Mg. Ing. Ariel Alejandro Vega</li>

### <li>Tecn. Kevin Alexis Roman Llampa</li>

### </ul>

### <hr>

### <h2>🎮 Descripción del Proyecto</h2>

### <p>Red.Jr sigue la pequeña aventura del mismo, debe liberar a su padre de la jaula en la que fue atrapado, quien lo puso ahi? No es importante (Por ahora al menos). Se trata de un plataformero 3D basico, realizado con el objetivo de cumplir con los conocimientos dados en la materia.</p>

### <hr>

### <h2>🕹️ Controles del Jugador</h2>

### <table>

### <thead>

### <tr>

### <th>Acción</th>

### <th>Tecla</th>

### <th>Descripción</th>

### </tr>

### </thead>

### <tbody><tr>

### <td>Movimiento</td>

### <td>W, A, S, D</td>

### <td>Mover al personaje</td>

### </tr>

### <tr>

### <td>Cámara</td>

### <td>Mouse</td>

### <td>Rotar la cámara</td>

### </tr>

### <tr>

### <td>Salto</td>

### <td>Espacio</td>

### <td>Saltar entre plataformas</td>

### </tr>

### <tr>

### <td>Interacción</td>

### <td>E</td>

### <td>Alzar objetos y dejarlos</td>

### </tr>

### </tbody></table>

### <hr>

### <h2>📸 Capturas de Pantalla</h2>

### <h3>Plataformas Moviles</h3>

### <p>Imagenes/captura01.png</p>

### <h3>Padre</h3>

### <p>Imagenes/captura02.png</p>

### <hr>

### <h2>📝 Explicación Técnica del Código</h2>

### <h3>1️⃣ Generación de Plataformas (Invoke)</h3>

### <p><strong>Script:</strong> <code>GeneradorBehavior.cs</code></p>

### <p><strong>Objetivo:</strong><br>La plataforma aparece, recorre una distancia determinada y luego desaparece.</p>

### <pre><code class="language-csharp">void Start()

### &#x20;   {

### &#x20;       InvokeRepeating("GenerarPlataforma", TiempoInicio, TiempoGeneracion);

### &#x20;   }

### </code></pre>

### <p><strong>Explicación:</strong></p>

### <ul>

### <li><code>Invoke()</code> ejecuta un método luego de cierto tiempo.</li>

### <li>En este caso esta determinado por TiempoGeneracion.</li>

### </ul>

### <hr>

### <h3>2️⃣ Corrutinas (Coroutine)</h3>

### <p><strong>Script:</strong> <code>SpeedPowerUp.cs</code></p>

### <p><strong>Objetivo:</strong><br>Esperar un período de tiempo antes de volver a mostrar el PowerUp.</p>

### <pre><code class="language-csharp">private IEnumerator RespawnSpeed()

### &#x20;   {

### &#x20;       renderer.enabled = false;

### &#x20;       powerUpCollider.enabled = false;

### &#x20;       yield return new WaitForSeconds(20f);

### &#x20;       renderer.enabled = true;

### &#x20;       powerUpCollider.enabled = true;

### &#x20;   }

### </code></pre>

### <p><strong>Explicación:</strong></p>

### <ul>

### <li><code>IEnumerator</code> permite crear una corrutina.</li>

### <li><code>WaitForSeconds()</code> pausa la ejecución.</li>

### <li>Después del tiempo indicado el PowerUp vuelve a activarse.</li>

### </ul>

### <hr>

### <h3>3️⃣ Emparentamiento (SetParent)</h3>

### <p><strong>Script:</strong> <code>PickUpItem.cs</code></p>

### <p><strong>Objetivo:</strong><br>Permitir que el jugador recoja un objeto y lo coloque en su mano.</p>

### <pre><code class="language-csharp">private void PickUpItem(GameObject item)

### &#x20;   {

### &#x20;       item.transform.SetParent(hand);

### &#x20;       item.transform.localPosition = Vector3.zero;

### &#x20;       item.transform.localRotation = Quaternion.identity;

### &#x20;       currentItem = item;

### &#x20;       Collider itemCollider = item.GetComponent\&lt;Collider\&gt;();

### 

### &#x20;       if(itemRb!=null)

### &#x20;       {

### &#x20;           itemRb.isKinematic = true;

### &#x20;       }

### 

### &#x20;       if(itemCollider!=null)

### &#x20;       {

### &#x20;           itemCollider.enabled = false;

### &#x20;       }

### &#x20;       Debug.Log("Recogido");

### &#x20;   }

### </code></pre>

### <p><strong>Explicación:</strong></p>

### <ul>

### <li>Coloca al objeto como hijo de Hand, asi el jugador puede llevar el objeto consigo.</li>

### <li>Coloca el objeto exactamente en la mano.</li>

### <li>Tambien reinicia su rotación para que concuerde con Hand.</li>

### </ul>

### <hr>

### <h2>⚙️ Tecnologías Utilizadas</h2>

### <ul>

### <li>Unity 6</li>

### <li>C#</li>

### <li>Git</li>

### <li>GitHub</li>

### </ul>

### <hr>

### <h2>👤 Autor</h2>

### <p><strong>Mateo Carrizo</strong></p>

### <p>Tecnicatura Universitaria en Diseño Integral de Videojuegos - UNJu</p>



