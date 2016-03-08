<?php
//define variables
$userid = $_POST['userid'];
$post_content = $_POST['post_content'];
}

//connect to database
include "db.php";

try {
$sql = "INSERT into posts(userid, post_content) VALUES (
	:userid,
	:post_content,)";
	
	$stmt = $pdo->prepare($sql);
	
	$stmt->bindParam(':userid', $userid, PDO::PARAM_STR);
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