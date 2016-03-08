<?php
session_start();

//define variables
$post_content = $_POST['post'];

//connect to database
include "db.php";

IF ($_SESSION['userid'] == ""){
	echo "error";
	exit();
	}

try {
$sql = "INSERT into posts(UserID, Post_Content) VALUES (
	:userid,
	:post_content)";
	
	$stmt = $pdo->prepare($sql);
	
	$stmt->bindParam(':userid', $_SESSION['userid'], PDO::PARAM_INT);
	$stmt->bindParam(':post_content', $post_content, PDO::PARAM_STR);

	$stmt->execute();
	}
	
	catch(PDOException $e) {
		echo "Error !: " . $e->getMessage() . "<br>";
		exit();
		}
		
	if($stmt == false) {
		echo '<a href="posts.php">Error cannot execute query</a>';
		}
		
		else
		{
			header('location:posts.php');
		}
	
	exit();
	?>