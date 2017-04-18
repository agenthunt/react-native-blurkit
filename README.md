
# react-native-blur-kit

## Getting started

`$ npm install react-native-blur-kit --save`

### Mostly automatic installation

`$ react-native link react-native-blur-kit`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-blur-kit` and add `RNBlurKit.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNBlurKit.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNBlurKitPackage;` to the imports at the top of the file
  - Add `new RNBlurKitPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-blur-kit'
  	project(':react-native-blur-kit').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-blur-kit/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-blur-kit')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNBlurKit.sln` in `node_modules/react-native-blur-kit/windows/RNBlurKit.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Com.Reactlibrary.RNBlurKit;` to the usings at the top of the file
  - Add `new RNBlurKitPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNBlurKit from 'react-native-blur-kit';

// TODO: What to do with the module?
RNBlurKit;
```

## TODO

- [] Android support
- [] iOS support
  