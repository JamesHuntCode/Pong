var ball;
var paddle;

function setup() {
  createCanvas(600, 600);
  ball = new ball(width / 2, height / 2);
  paddle = new paddle(width / 2, height - 20);
}

function draw() {
  background(51);

  // Draw ball
  ball.update();
  ball.show();
  ball.bounce();
  ball.offScreen();

  if (ball.hitsPaddle(paddle.posX, paddle.posY, paddle.width)) {
    ball.velY = -ball.velY;
  }

  // Draw paddle
  paddle.show();
}

function keyPressed() {
  if (keyCode === LEFT_ARROW) {
    paddle.move("left");
  } else if (keyCode === RIGHT_ARROW) {
    paddle.move("right");
  }
}
