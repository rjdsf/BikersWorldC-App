	<!DOCTYPE html>
	<html lang="en">
	<head>
	<title>My PHP Stuff</title>
	<link rel="stylesheet" href="styles.css" type="text/css">
	<meta charset="UTF-8">
	</head>
	<body>
	<div id="container">
	<header>Mini Facebook</header>
	<?php include ('navigation.php') ?>
	<section id="main">
		<form method="post" action="post_action.php" name="posts">
		<fieldset>
		<legend>Posts</legend>
		<br>
		<label>Enter Post</label><input type="text" name="post"><br>
		<input type="submit" value="Submit">
			</fieldset>
			</form>
	</section>
	<footer>
	</footer>
	<!-- close container --></div>
	</body>
	</html>