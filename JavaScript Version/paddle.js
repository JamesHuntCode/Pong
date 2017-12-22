function paddle(x, y) {
  this.posX = x;
  this.posY = y;
  this.height = 20;
  this.width = 100;

  this.show = function() {
    rect(this.posX, this.posY, this.width, this.height);
  }

  this.move = function(direction) {
    if (direction === "left") {
      this.posX -= 50;
    } else {
      this.posX += 50;
    }
  }
}
