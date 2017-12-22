var ball;

function setup() {
  createCanvas(600, 600);
  ball = new ball(width / 2, height / 2);
}

function draw() {
  background(51);

  ball.update();
  ball.show();
  ball.bounce();
}
