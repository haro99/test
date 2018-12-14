using System;

//硬貨組み合わせ（重複あり）
//入力は整数一つ
public class Test
{
	static int[]coin=new int[]{1,5,10,50,100,500};
	

	public static void Main()
	{
		string line;
		int a,b,cnt;
		
		a=coin.Length;
		line=Console.ReadLine();
		b=int.Parse(line);
		//	組み合わせ関数を呼び出してcntに代入
		cnt=combination(b, a - 1);
		//	組み合わせ個数を表示
		Console.WriteLine(cnt);
		
	}
	static int combination(int rest, int uidx)
	{
		//cntは組み合わせ個数
		int i, cnt;
		
		//残金が0ならな
		if(rest == 0)
		{
			//残金が0なので1を返す
			return 1;
		}
		else
		{
			cnt = 0;
			for(i = uidx;i >= 0;i--){
				//coinの硬貨より大きいか？
				if(rest >= coin[i])
				{
					//残金を引いて再帰させる
					cnt += combination(rest-coin[i],i);
				}
			}
			//今までの組み合わせ個数を返す
			return cnt;
		}
	}

	
}
