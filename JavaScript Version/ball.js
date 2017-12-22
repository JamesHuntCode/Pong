function ball(x, y) {
  this.size = 20;
  this.posX = x;
  this.posY = y;
  this.velX = Math.floor(Math.random()*4)+2;
  this.velY = Math.floor(Math.random()*4)+2;

  this.update = function() {
    this.posX += this.velX;
    this.posY += this.velY;
  }

  this.show = function() {
    ellipse(this.posX, this.posY, this.size, this.size);
  }

  this.bounce = function() {
    if (this.posY - this.size / 2 < 0 || this.posY + this.size / 2 > height) {
      this.velY = -this.velY;
    }

    if (this.posX - this.size / 2 < 0 || this.posX + this.size / 2 > width) {
      this.velX = -this.velX;
    }
  }
}
