package com.app.madupketbot;

import java.text.DecimalFormat;
import java.util.ArrayList;
import java.util.List;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import com.app.madupketbot.MainActivity.TalkInfo;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.content.res.ColorStateList;
import android.graphics.Color;
import android.graphics.Paint;
import android.os.Handler;
import android.os.Message;
import android.support.v4.app.Fragment;
import android.support.v4.app.FragmentManager;
import android.support.v4.app.FragmentPagerAdapter;
import android.support.v4.view.PagerAdapter;
import android.support.v4.view.ViewPager;
import android.support.v4.view.ViewPager.OnPageChangeListener;
import android.util.Log;
import android.view.Gravity;
import android.view.LayoutInflater;
import android.view.MotionEvent;
import android.view.View;
import android.view.ViewGroup;
import android.view.View.OnClickListener;
import android.widget.BaseAdapter;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.RelativeLayout;
import android.widget.TextView;

public class Adapter_Advice_List extends BaseAdapter
{
	 private Context mContext = null;
	 private List<String> sdcardpath;	
	 private ArrayList<TalkInfo> mItemList = new ArrayList<TalkInfo>();
	  
	 public Adapter_Advice_List(Context con, ArrayList<TalkInfo> items){
	     this.mContext = con;
	     this.mItemList = items;
	 }
	  
	 // 이미지의 갯수 
	 @Override
	 public int getCount() {
	  // TODO Auto-generated method stub
//	  Log.d("test9", "itemcount =" + mItemList.size());
	  return mItemList.size();
	 }
	 
	 @Override
	 public Object getItem(int position) {
	  // TODO Auto-generated method stub
	  return position ;
	 }
	 
	 // 선택된 이미지ID를 반환
	 @Override
	 public long getItemId(int position) {
	  // TODO Auto-generated method stub
	  return position;
	 }
	 
	 @Override
	 public View getView(int position, View convertView, ViewGroup parent) {
	  		 
	      View v = convertView;
	      v = View.inflate(mContext, R.layout.item_advice_list, null);
	      TalkInfo tmp = mItemList.get(position);
	      
		  RelativeLayout layout = (RelativeLayout) v.findViewById(R.id.advice_lost_layout);
		  RelativeLayout layout2 = (RelativeLayout) v.findViewById(R.id.advice_date_layout);
		  TextView tv_desc  = (TextView) v.findViewById(R.id.advice_txt);
		  TextView tv_date  = (TextView) v.findViewById(R.id.advice_date);
		  
	
	   	  if(tmp.type.equals("1")) //user
		  {	  
	   		  tv_desc.setBackgroundResource(R.drawable.message_area_blue);
	   		  tv_desc.setText(tmp.desc);
	   		  tv_desc.setTextColor(Color.parseColor("#ffffff"));
			  layout.setGravity(Gravity.RIGHT);
			  layout2.setGravity(Gravity.RIGHT);
			  
		  }
		  else  //finket
		  {
			  tv_desc.setBackgroundResource(R.drawable.message_area_white);
	   		  tv_desc.setText(tmp.desc);
	   		  tv_desc.setTextColor(Color.parseColor("#000000"));
			  layout.setGravity(Gravity.LEFT);
			  layout2.setGravity(Gravity.LEFT);
		  }
		
//		  if(tmp.getString("message").equals(""))
//		  {
//			  tv_desc.setVisibility(View.GONE);
//			  Picasso.with(mContext).load(URLs.BASE_HOST.getValue() + tmp.getString("loc")).fit().memoryPolicy(MemoryPolicy.NO_CACHE, MemoryPolicy.NO_STORE).into(iv_img);
//		  }
//		  else
//		  {
//			 tv_desc.setText(tmp.getString("message"));
//			 iv_img.setVisibility(View.GONE);
//		  }
//		  tv_date.setText(tmp.getString("writedate").substring(0,16));
	
	 return v;
	 }
}
