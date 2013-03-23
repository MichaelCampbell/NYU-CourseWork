#ifndef BMIH       
#define BMIH

class BMI {
	int height;
	int weight;
	bool sex; //0 = female, 1 = male
public:
	BMI(float initial_height, float initial_weight, bool initial_sex);
	void BMICalc(float weight, float height, bool sex);
	void print(float BMIresult, bool sex);
};
#endif

