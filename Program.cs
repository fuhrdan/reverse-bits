//*****************************************************************************
//** 190. Reverse Bits                                              leetcode **
//*****************************************************************************
//** Take the bits and reverse them through
//** an inverse answer will show true
//** With a binary shift 
//** The answer is a gift
//*****************************************************************************

int reverseBits(int n) {
    int ans = 0;
    for(int i = 0; i < 32 && n; i++)
    {
        ans |= (n & 1) << (31 - i);
        n >>= 1;
    }
    return ans;
}