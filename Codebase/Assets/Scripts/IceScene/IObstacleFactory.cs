﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObstacleFactory {

	void createObstacle(GameObject obstacle,float x, float y, float z);
}
