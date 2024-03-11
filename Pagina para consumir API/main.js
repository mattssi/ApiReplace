document.addEventListener('DOMContentLoaded', function () {
    const obtenerChisteBtn = document.getElementById('obtenerChisteBtn');
    const chisteContainer = document.getElementById('chisteContainer');

    obtenerChisteBtn.addEventListener('click', function () {
        cargarContenido();
    });

    function cargarContenido() {
        // Configura la URL de tu API
        const apiUrl = 'http://localhost:5108/Chiste';

        // Realiza la solicitud utilizando Fetch 
        fetch(apiUrl)
            .then(response => {
                // Verifica si la solicitud fue exitosa
                if (!response.ok) {
                    throw new Error(`Error al obtener el chiste: ${response.status}`);
                }
                // Verifica el tipo de contenido de la respuesta
                const contentType = response.headers.get('content-type');
                if (contentType && contentType.includes('application/json')) {
                    // Si el contenido es JSON, parsea la respuesta
                    return response.json();
                } else {
                    // Si no es JSON, devuelve el contenido como texto
                    return response.text();
                }
            })
            .then(data => {
                // Muestra el chiste en el contenedor
                mostrarChiste(data);
            })
            .catch(error => {
                // Maneja errores en la obtención del chiste
                console.error('Error al obtener el chiste:', error.message);
                console.error('Detalles del error:', error);
            });
    }

    function mostrarChiste(chisteData) {
        // Limpiar el contenedor antes de mostrar un nuevo chiste
        chisteContainer.innerHTML = '';

        // Crear elementos HTML para mostrar el chiste
        const parrafo = document.createElement('p');
        parrafo.textContent = chisteData;

        // Agregar el chiste al contenedor
        chisteContainer.appendChild(parrafo);
    }
});
