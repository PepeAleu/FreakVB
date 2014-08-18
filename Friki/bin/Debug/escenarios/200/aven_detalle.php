<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" lang="es-ES" xml:lang="es-ES">

<head>
	<title>Universos</title>
	<meta http-equiv="Content-Type" content="application/xhtml+xml; charset=utf-8" />
	<meta name="description" content="Aplicación web de la base de datos friki" />
	<meta name="keywords" content="friki web" />
	<meta name="robots" content="index, follow" />
	<link rel="shortcut icon" href="/favicon.ico" type="image/x-icon" />
	<link rel="stylesheet" type="text/css" href="css/estilos.css" media="screen" />
</head>

<body background="pics/fondo2.jpg">
<?php 
include("librerias/basicas.php");
include("librerias/connect.php");
get_header();
$link=Conectarse();
 
$id = $_POST['id'];
$result =mysql_query("select aventuras.id_ave, 
							 escenarios.nombre as escenario_nombre, 
							 aventuras.nombre as aventura_nombre, 
							 aventuras.descripcion, 
							 objetos.nombre as objeto_nombre, 
							 cantidad 
					from aventuras, objetos, escenarios
					where 	id_ave = ".$id." AND
							aventuras.id_obj = objetos.id_obj AND
							aventuras.id_esc = escenarios.id_esc;");
$row = mysql_fetch_array($result);

?>

	<div class="general">
		<div class="contenido">
			<b class="tituloDetalles"><?php echo $row['aventura_nombre']?> </b>
				<div class="titulo"> </div>
				
				<div class="detalles"> 
					<div class="foto">
						<img src="pics/Escenario/200/<?php echo $row['id_esc']?>.jpg">
					</div>	
					<table class="detallestable">
						<tr>
							<td>
								<b>Nombre:</b> 
							</td>
							<td class="datos">
								<?php echo $row['aventura_nombre']?>
							</td>
						</tr>
						<tr>
							<td>
								<b>Escenario:</b>
							</td>
							<td class="datos">
								<?php echo $row['escenario_nombre']?>
							</td>
						</tr>
						<tr>
							<td>
								<b>Descripcion:</b>
							</td>
							<td class="datos">
								<?php echo $row['descripcion']?>
							</td>
						</tr>
						<tr>
							<td>
								<b>Tesoro:</b>
							</td>
							<td class="datos">
								<?php echo $row['objeto_nombre']?>
							</td>
						</tr>
						<tr>
							<td>
								<b>Cantidad:</b>
							</td>
							<td class="datos">
								<?php echo $row['cantidad']?>
							</td>
						</tr>
					</table>
					
					<hr>	
				</div>
		</div>
	</div>
<?

?>
</body>
</html>