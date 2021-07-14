const character =document.getElementById("character");
const obstacle =document.getElementById("obstacle");

function jump() {
    if (character.classList != "jump") {
        character.classList.add("jump");

        setTimeout(function() {
            character.classList.remove("jump");
        }, 300);
    }
}

let isAlive = setInterval(function() {
    
   let characterTop = parseInt(window.getComputedStyle(character).getPropertyValue("top"));
 
   let obstacleLeft =parseInt(
    window.getComputedStyle(obstacle).getPropertyValue("left")
   );
   
   if (obstacleLeft < 20 && obstacleLeft > 0 && characterTop >= 140) {

    
    alert ("Game Over!");
    
   }
}, 10);

document.addEventListener("keydown", function (event) {
    jump();
});
