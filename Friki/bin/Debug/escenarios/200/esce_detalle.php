<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" lang="es-ES" xml:lang="es-ES">

<head>
	<title>Escenarios</title>
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
$result =mysql_query("select * from escenarios where id_esc = ".$id.";");
$row = mysql_fetch_array($result);
if ($row['esplaneta']==1){
	$esplaneta="Planeta";
}else{
	$esplaneta="No Es Planeta";
}
if ($row['esc_padre']==null){
	$padre="No Tiene Padre";
}else{
	$result = mysql_query("Select nombre from escenarios where id_esc =".$row['id_esc'].";");
	$esc_padre = mysql_fetch_array($result);
	$padre = $esc_padre['nombre'];
}
$result = mysql_query("Select nombre from universos where id_uni =".$row['id_uni'].";");
$row2 = mysql_fetch_array($result);
?>

	<div class="general">
		<div class="contenido">
			<b class="tituloDetalles"><?php echo $row['nombre']?></b>
				<div class="titulo"></div>
				
				<div class="detalles"> 
					<div class="foto">
						<img src="pics/escenarios/200/<?php echo $row['id_esc']?>.jpg">
					</div>
					<table class="detallestable">
						<tr>
							<td>
								<b>Nombre:</b> 
							</td>
							<td class="datos">
								<?php echo $row['nombre']?>
							</td>
						</tr>
						<tr>
							<td>
								<b>Poblaci&oacute;n:</b>
							</td>
							<td class="datos">
								<?php echo $row['poblacion']?>
							</td>
						</tr>
						<tr>
							<td>
								<b>Poblaci&oacute;n M&aacute;xima:</b>
							</td>
							<td class="datos">
								<?php echo $row['poblacionmaxima']?>
							</td>
						</tr>
						<tr>
							<td>
								<b>Planeta:</b> 
							</td>
							<td class="datos">
								<?php echo $esplaneta?>
							</td>
						</tr>
						<tr>
							<td>
								<b>Escenario Padre:</b> 
							</td>
							<td class="datos">
								<?php echo $padre?>
							</td>
						</tr>
					</table>
					
					<hr>	
					<div class="detalles2">	
						<img src="pics/universos/75/<?php echo $row['id_uni']?>.jpg">
					</div>
				</div>
		</div>
	</div>
<?

?>
</body>
</html>