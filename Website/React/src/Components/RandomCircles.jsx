import React from "react";

const RandomCircles = () => {
  const circles = Array.from({ length: 10 }, (_, index) => ({
    left: `${Math.random() * 100}vw`,
    top: `${Math.random() * 100}vh`,
  }));

  return (
    <div className="absolute top-0 left-0 w-full h-full -z-10">
      {circles.map((circle, index) => (
        <div
          key={index}
          className="absolute w-16 h-16 bg-blue-300 rounded-full opacity-50"
          style={{ left: circle.left, top: circle.top }}
        ></div>
      ))}
    </div>
  );
};

export default RandomCircles;
