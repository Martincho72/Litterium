document.getElementById('boton-descarga').addEventListener('click', function() {
  // URL del archivo en Google Drive
  const fileUrl = 'https://drive.google.com/uc?export=download&id=1iqnsbCWK95WnOgn2B1GjJWddszeeGbkw';

  // Crear un elemento <a> temporal para simular el clic y descargar el archivo
  const a = document.createElement('a');
  a.href = fileUrl;
  a.target = '_blank';
  a.download = 'Litterium.zip'; // Nombre del archivo que se descargará

  // Añadir el elemento al cuerpo, simular el clic y luego removerlo
  document.body.appendChild(a);
  a.click();
  document.body.removeChild(a);
});
