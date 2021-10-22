﻿#include <iostream>
#include <fstream>
#include <string>
using namespace std;

int power(int a, int b, int n) {// a^b mod n
    int tmp = a;
    int sum = tmp;
    for (int i = 1; i < b; i++) {
        for (int j = 1; j < a; j++) {
            sum += tmp;
            if (sum >= n) {
                sum -= n;
            }
        }
        tmp = sum;
    }
    return tmp;
}

int mul(int a, int b, int n) {// a*b mod n 
    int sum = 0;

    for (int i = 0; i < b; i++) {
        sum += a;

        if (sum >= n) {
            sum -= n;
        }
    }

    return sum;
}

/*****************************************************
    p - простое число
    0 < g < p-1
    0 < x < p-1
    m - шифруемое сообщение m < p
*****************************************************/
void crypt(int p, int g, int x, string inFileName, string outFileName) {
    ifstream inf(inFileName.c_str());
    ofstream outf(outFileName.c_str());

    int y = power(g, x, p);

    wcout << "Open key (p,g,y)=" << "(" << p << "," << g << "," << y << ")" << endl;
    wcout << "Lock key x=" << x << endl;

    wcout << "\nText before:" << endl;

    while (inf.good()) {
        int m = inf.get();
        if (m > 0) {
            wcout << (char)m;

            int k = rand() % (p - 2) + 1; // 1 < k < (p-1) 
            int a = power(g, k, p);
            int b = mul(power(y, k, p), m, p);
            outf << a << " " << b << " ";
        }
    }

    wcout << endl;

    inf.close();
    outf.close();
}

void decrypt(int p, int x, string inFileName, string outFileName) {
    ifstream inf(inFileName.c_str());
    ofstream outf(outFileName.c_str());

    wcout << "\nText after:" << endl;

    while (inf.good()) {
        int a = 0;
        int b = 0;
        inf >> a;
        inf >> b;

        if (a != 0 && b != 0) {
            //wcout<<a<<" "<<b<<endl; 

            int deM = mul(b, power(a, p - 1 - x, p), p);// m=b*(a^x)^(-1)mod p =b*a^(p-1-x)mod p - трудно было  найти нормальную формулу, в ней вся загвоздка 
            char m = static_cast<char>(deM);
            outf << m;
            wcout << m;
        }
    }

    wcout << endl;

    inf.close();
    outf.close();
}

int main() {
    srand(time(NULL));

    crypt(593, 123, 8, "in.txt", "out_crypt.txt");
    decrypt(593, 8, "out_crypt.txt", "out_decrypt.txt");

    return 0;
}
