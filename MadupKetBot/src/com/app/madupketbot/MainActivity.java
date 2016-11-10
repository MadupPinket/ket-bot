package com.app.madupketbot;

import java.io.ByteArrayOutputStream;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.OutputStream;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.HashMap;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import ch.boye.httpclientandroidlib.HttpEntity;
import ch.boye.httpclientandroidlib.HttpResponse;
import ch.boye.httpclientandroidlib.client.ClientProtocolException;
import ch.boye.httpclientandroidlib.client.HttpClient;
import ch.boye.httpclientandroidlib.client.ResponseHandler;
import ch.boye.httpclientandroidlib.client.methods.HttpPost;
import ch.boye.httpclientandroidlib.entity.ContentType;
import ch.boye.httpclientandroidlib.entity.mime.HttpMultipartMode;
import ch.boye.httpclientandroidlib.entity.mime.MultipartEntityBuilder;
import ch.boye.httpclientandroidlib.impl.client.BasicResponseHandler;
import ch.boye.httpclientandroidlib.impl.client.DefaultHttpClient;
import ch.boye.httpclientandroidlib.protocol.HTTP;
import ch.boye.httpclientandroidlib.util.EntityUtils;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Color;
import android.graphics.drawable.StateListDrawable;
import android.net.ConnectivityManager;
import android.net.NetworkInfo;
import android.net.NetworkInfo.State;
import android.os.Bundle;
import android.os.Environment;
import android.os.Handler;
import android.os.Looper;
import android.os.StrictMode;
import android.provider.MediaStore;
import android.util.Base64;
import android.util.Log;
import android.view.View;
import android.view.Window;
import android.view.View.OnClickListener;
import android.view.inputmethod.InputMethodManager;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.EditText;
import android.widget.GridView;
import android.widget.ImageView;
import android.widget.RelativeLayout;
import android.widget.Toast;


public class MainActivity extends Activity {
  
	private RelativeLayout baseView;
	private Context mContext;
	private EditText et_input;
	private Button btn_asknumber, btn_done;
	private ImageView iv_back, iv_add;
	private GridView girdv_list;
	private Adapter_Advice_List adapter_vlist;
	private Bitmap useruploadbitmap;
	private ArrayList<TalkInfo> alist_talklist = new ArrayList<TalkInfo>();
	
	private String TAG ="BJLee_Advice";
    
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
        setContentView(R.layout.activity_advice);
        
        mContext = this;
        if(android.os.Build.VERSION.SDK_INT > 9) {
       	   StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder().permitAll().build();
       	   StrictMode.setThreadPolicy(policy);
       	}

        setLayout();
        setInit();
    }
    
    void setLayout()
    {
    	girdv_list    = (GridView) findViewById(R.id.advice_gridview);
    	btn_done = (Button) findViewById(R.id.advice_done);
    	et_input = (EditText) findViewById(R.id.advice_input);
    	iv_back  = (ImageView) findViewById(R.id.back);
    	
    	iv_back.setOnClickListener(new OnClickListener() {
  			@Override
  			public void onClick(View v) {
  				  finish();
  			  }
  		  });
    }
    
    void setInit()
    {
    	btn_done.setOnClickListener(new OnClickListener() {
  		    @Override
  			public void onClick(View v) {
  		
//  		    	if(et_input.equals(""))
//  		    		Toast.makeText(mContext, "상담 내용을 입력해 주세요.", Toast.LENGTH_SHORT).show();
//  		    	else
  		    	{
	  		        InputMethodManager mInputMethodManager = (InputMethodManager)getSystemService(Context.INPUT_METHOD_SERVICE);
	  	            mInputMethodManager.hideSoftInputFromWindow(et_input.getWindowToken(), 0);
	  	            
	  	            getConversationID();
  		    	}
  			}
  		});
    	
    	TalkInfo tmp1 = new TalkInfo();
    	tmp1.desc ="안녕하세요, 회원님!\n회원님을 도와드릴 채팅로봇 '켓' 입니다.\n무엇을 도와드릴까요??";
    	tmp1.type ="2";
    	alist_talklist.add(tmp1);
    	
    	TalkInfo tmp2 = new TalkInfo();
    	tmp2.desc ="문의하자 하는 항목을 선택하거나,\n말씀해주세요.\n1. 포인트 통합\n2. 포인트 사용\n3. 광고 포인트적립\n4. 맴버쉽\n.5 상점\n6. 기타 문의";
    	tmp2.type ="2";
    	alist_talklist.add(tmp2);
    	
    	TalkInfo tmp3 = new TalkInfo();
    	tmp3.desc ="2";
    	tmp3.type ="1";
    	alist_talklist.add(tmp3);
    	
    	adapter_vlist = new Adapter_Advice_List(mContext, alist_talklist);
    	girdv_list.setAdapter(adapter_vlist);
    	girdv_list.setSelector(new StateListDrawable());
    	if(alist_talklist.size()>5)
    		girdv_list.setSelection(alist_talklist.size()-1);

    }
    
    
    
    @Override
    protected void onPause() {
        super.onPause();
    }
    
    private void getConversationID() {
    	
    	HttpClient httpclient = new DefaultHttpClient();
	    HttpPost httppost = new HttpPost("https://directline.botframework.com/api/conversations/");
	    httppost.setHeader("Authorization", "BotConnector ISvUpBBwW6g.cwA.QLc.G1vylc9eBfhoxAx2_Raahi35NW776axNfovhXlZhE0g");
	    httppost.addHeader("Authorization", "BotConnector ISvUpBBwW6g.cwA.QLc.G1vylc9eBfhoxAx2_Raahi35NW776axNfovhXlZhE0g");
	    Log.d("DEBUG", "HEADERS: " + httppost.getFirstHeader("Authorization: BotConnector"));

	    ResponseHandler<String> responseHandler = new BasicResponseHandler();
	    String responseBody = null;
		try {
			responseBody = httpclient.execute(httppost, responseHandler);
		} catch (ClientProtocolException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

	    Log.d("BJLee", "RESPONSE: " + responseBody);
    
	} 
    
    
    private boolean isOnline() { // network 연결 상태 확인
    	try {
	    	ConnectivityManager conMan = (ConnectivityManager) mContext.getSystemService(Context.CONNECTIVITY_SERVICE);
	
	    	State wifi = conMan.getNetworkInfo(1).getState(); // wifi
	    	if (wifi == NetworkInfo.State.CONNECTED || wifi == NetworkInfo.State.CONNECTING) {
	    	return true;
	    	}
	
	    	State mobile = conMan.getNetworkInfo(0).getState(); // mobile ConnectivityManager.TYPE_MOBILE
	    	if (mobile == NetworkInfo.State.CONNECTED || mobile == NetworkInfo.State.CONNECTING) {
	    	return true;
	    	}
    	} catch (NullPointerException e) {
    	return false;
    	}

    	return false;
    }
    
    
    public class TalkInfo {
    	
    	public String desc;
    	public String date;
    	public String type; // 1:user, 2:finket
    
    	public TalkInfo() { }
    	
    	public TalkInfo(String desc, String date, String type){
    		this.desc = desc;
    		this.date = date;
    		this.type = type;
    	}
    }

    
}
