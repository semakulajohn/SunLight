//using System;
//using System.Net.Http.HttpClient.ClientProtocolException;
//using org.apache.http.client.methods.CloseableHttpResponse;
//using org.apache.http.client.methods.HttpGet;
//using org.apache.http.HttpEntity;
//using org.apache.http.impl.client.CloseableHttpClient;
//using org.apache.http.impl.client.HttpClients;
//using org.apache.http.ParseException;
//using org.apache.http.util.EntityUtils;
//using org.json.JSONException;
//using org.json.JSONObject;
//using System.Json;
//using System.Collections.Generic;
//using System.Collections;
//using System.IO;
//using System.Text.DateFormat;
//using System.Text.SimpleDateFormat;

//namespace SunLight.Helpers
//{
//  public  class Converter
//    {
        
//    public static readonly string ACCESS_KEY = "YOUR_ACCESS_KEY";
//    public static readonly string BASE_URL = "http://apilayer.net/api/";
//    public static readonly string ENDPOINT = "live";

// CloseableHttpClient  = HttpClients.createDefault();


//    public static void sendLiveRequest(){

//        HttpGet get = new HttpGet(BASE_URL + ENDPOINT + "?access_key=" + ACCESS_KEY);

//        try {
//            CloseableHttpResponse response =  httpClient.execute(get);
//            HttpEntity entity = response.getEntity();

//            JSONObject exchangeRates = new JSONObject(EntityUtils.toString(entity));

//            Console.WriteLine("Live Currency Exchange Rates");

          
//            DateTime timeStampDate = new DateTime((long)(exchangeRates.getLong("timestamp")*1000)); 
//            DateFormat dateFormat = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss a");
//            string formattedDate = dateFormat.format(timeStampDate);
//            Console.WriteLine("1 " + exchangeRates.getString("source") + " in GBP : " + exchangeRates.getJSONObject("quotes").getDouble("USDGBP") + " (Date: " + formattedDate + ")");   
//            Console.WriteLine("\n");
//            response.close();
//        }
//          catch (ClientProtocolException e) {
            
//            e.printStackTrace();
//        } catch (IOException e) {
           
//            e.printStackTrace();
//        } catch (ParseException e) {
          
//            e.printStackTrace();
//        } catch (JSONException e) {
          
//            e.printStackTrace();
//        }
//    }

//    public static void main(String[] args) throws IOException{
//        sendLiveRequest();
//        httpClient.close();
//        new BufferedReader(new InputStreamReader(System.in)).readLine();
//    }
//}
//    }
//}
