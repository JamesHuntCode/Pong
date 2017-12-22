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
      if (this.posX - this.width / 2 >= 0) {
        this.posX -= 50;
      }
    } else {
      if (this.posX + this.width + 50 <= width) {
        this.posX += 50;
      }
    }
  }
}
