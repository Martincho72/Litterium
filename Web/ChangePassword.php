<?php

if (isset($_REQUEST['usuario']) && isset($_REQUEST['clave']) && isset($_REQUEST['nuevaClave'])) {
    mysqli_report(MYSQLI_REPORT_ERROR);
    $servidor = "database-1.c2x0fjvt1inr.us-east-1.rds.amazonaws.com";
    $usuarioDB = "admin";
    $claveDB = "testtest";

    @$mysqli = new mysqli($servidor, $usuarioDB, $claveDB);
    if ($mysqli->connect_errno) {
        echo "Failed to connect to MySQL: " . $mysqli->connect_errno . " " . $mysqli->connect_error;
        die("Program exit. Database access error.");
    }

    $basedatos = "litterium";
    $mysqli->select_db($basedatos);
    $usuario = $_REQUEST['usuario'];
    $clave = $_REQUEST['clave'];
    $nuevaClave = $_REQUEST['nuevaClave'];

    $consulta = "SELECT contrasenya FROM usuarios WHERE usuario = ?";
    $stmt = $mysqli->prepare($consulta);
    $stmt->bind_param("s", $usuario);
    $stmt->execute();
    $stmt->store_result();
    
    if ($stmt->num_rows == 1) {
        $stmt->bind_result($contrasenya);
        $stmt->fetch();

        if ($clave == $contrasenya) {
            $updateQuery = "UPDATE usuarios SET contrasenya = ? WHERE usuario = ?";
            $stmtUpdate = $mysqli->prepare($updateQuery);
            $stmtUpdate->bind_param("ss", $nuevaClave, $usuario);
            $stmtUpdate->execute();

            echo "<script>alert('Password updated successfully');</script>";
        } else {
            echo "<script>alert('Incorrect current password');</script>";
        }
    } else {
        echo "<script>alert('User not found');</script>";
    }

    $stmt->close();
    $mysqli->close();
} else {
    echo "<script>alert('Missing information');</script>";
}
echo "<script>window.location.href = './newPassword.html';</script>";
?>